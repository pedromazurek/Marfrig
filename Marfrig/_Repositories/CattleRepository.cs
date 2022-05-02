using Marfrig.Models;
using Marfrig.Models.Cattle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig._Repositories
{
    public class CattleRepository : BaseRepository, ICattleRepository
    {
        public CattleRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(AddCattleModel cattleModel)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("MFSP_CompraGado_Ins"))
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nom_Pecuarista", SqlDbType.VarChar).Value = cattleModel.CattleBreeder;
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = cattleModel.Animal;
                cmd.Parameters.Add("@Dat_Entrega", SqlDbType.DateTime).Value = cattleModel.SelectDeliveryDate;
                cmd.Parameters.Add("@Ind_Quantidade", SqlDbType.Int).Value = cattleModel.Quantity;

                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("MFSP_CompraGado_Del"))
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }
        public void Edit(AddCattleModel cattleModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("MFSP_CompraGado_Upd"))
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nom_Pecuarista", SqlDbType.VarChar).Value = cattleModel.CattleBreeder;
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = cattleModel.Animal;
                cmd.Parameters.Add("@Dat_Entrega", SqlDbType.DateTime).Value = cattleModel.SelectDeliveryDate;
                cmd.Parameters.Add("@Ind_Quantidade", SqlDbType.Int).Value = cattleModel.Quantity;
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<CattleModel> GetAll()
        {
            var buyList = new List<CattleModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"DECLARE @QtdPorPagina INT = 10,
                                            @Pagina       INT = 1;
                                  SELECT    tg.Seql_Id, 
                                            pe.Nome,
                                            tg.Dat_Entrega,
                                            tg.Ind_Quantidade,
                                            tg.Vlr_Compratotal
                                             -- tg.Ind_Impresso
                                  FROM    [MF_TransacaoGado] tg
                                  INNER JOIN MF_Pecuarista pe 
                                    ON pe.Id = tg.seql_IdPecuarista
                                  ORDER BY tg.Seql_Id asc
                                  OFFSET (@Pagina - 1) * @QtdPorPagina ROWS
                                   FETCH NEXT @QtdPorPagina ROWS ONLY;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cattleModel = new CattleModel();
                        cattleModel.Id = (int)reader[0];
                        cattleModel.CattleBreeder = reader[1].ToString();
                        cattleModel.SelectDeliveryDate = (DateTime)reader[2];
                        cattleModel.Quantity = reader[3].ToString();
                        cattleModel.Amount = (decimal)reader[4];
                        //cattleModel.Print = reader[5].ToString();
                        buyList.Add(cattleModel);
                    }
                }
            }
            return buyList;
        }
        
        public IEnumerable<CattleModel> GetByValue(string value)
        {
            var buyList = new List<CattleModel>();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string nome = value;
            DateTime data;

            if (DateTime.TryParse(value, out data))
            {
                using (var connection = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("MFSP_CompraGado_Sel"))
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@data", SqlDbType.DateTime).Value = data;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cattleModel = new CattleModel();
                            cattleModel.Id = (int)reader[0];
                            cattleModel.CattleBreeder = reader[1].ToString();
                            cattleModel.SelectDeliveryDate = (DateTime)reader[2];
                            cattleModel.Quantity = reader[3].ToString();
                            cattleModel.Amount = (decimal)reader[4];
                            buyList.Add(cattleModel);

                        }
                    }
                }
            }
            else
            {

                using (var connection = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("MFSP_CompraGado_Sel"))
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@nome", SqlDbType.NVarChar).Value = nome;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cattleModel = new CattleModel();
                            cattleModel.Id = (int)reader[0];
                            cattleModel.CattleBreeder = reader[1].ToString();
                            cattleModel.SelectDeliveryDate = (DateTime)reader[2];
                            cattleModel.Quantity = reader[3].ToString();
                            cattleModel.Amount = (decimal)reader[4];
                            buyList.Add(cattleModel);
                        }
                    }
                }
            }
            return buyList;
        }
        IEnumerable<GetCattleModel> ICattleRepository.GetAllCattles()
        {
            var CattleList = new List<GetCattleModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"
                                    SELECT  pe.Id, 
                                            pe.Nome
                                    FROM MF_Pecuarista pe";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cattleModel = new GetCattleModel();
                        cattleModel.Id = (int)reader[0];
                        cattleModel.CattleBreederAll = reader[1].ToString();
                        CattleList.Add(cattleModel);

                    }
                }
            }
            return CattleList;
        }
        public IEnumerable<GetAnimalModel> GetAllAnimals()
        {
            var AnimalList = new List<GetAnimalModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"
                                    SELECT  an.Id, 
                                            an.Descricao
                                    FROM MF_Animal an";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var animaModel = new GetAnimalModel();
                        animaModel.IdAnimal = (int)reader[0];
                        animaModel.Animal = reader[1].ToString();
                        AnimalList.Add(animaModel);

                    }
                }
            }
            return AnimalList;
        }

        public IEnumerable<CattleModel> GetAllPaginated()
        {
            var buyList = new List<CattleModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"DECLARE @QtdPorPagina INT = 10,
                                            @Pagina       INT = 2;
                                  SELECT    tg.Seql_Id, 
                                            pe.Nome,
                                            tg.Dat_Entrega,
                                            tg.Ind_Quantidade,
                                            tg.Vlr_Compratotal
                                             -- tg.Ind_Impresso
                                  FROM    [MF_TransacaoGado] tg
                                  INNER JOIN MF_Pecuarista pe 
                                    ON pe.Id = tg.seql_IdPecuarista
                                  ORDER BY tg.Seql_Id asc
                                  OFFSET (@Pagina - 1) * @QtdPorPagina ROWS
                                   FETCH NEXT @QtdPorPagina ROWS ONLY;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cattleModel = new CattleModel();
                        cattleModel.Id = (int)reader[0];
                        cattleModel.CattleBreeder = reader[1].ToString();
                        cattleModel.SelectDeliveryDate = (DateTime)reader[2];
                        cattleModel.Quantity = reader[3].ToString();
                        cattleModel.Amount = (decimal)reader[4];
                        //cattleModel.Print = reader[5].ToString();
                        buyList.Add(cattleModel);
                    }
                }
            }
            return buyList;
        }

        public void PrintCattle(List<CattleModel> model)
        {
            foreach (var item in model)
            {
                using (var connection = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = @"update MF_TransacaoGado 
                                        set Ind_Impresso = 1
                                        where Seql_Id=@Id";
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = item.Id;
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public IEnumerable<CattleModel> GetPrintAvailable(int id)
        {
            var buyList = new List<CattleModel>();
            
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT Ind_Impresso 
                                    FROM MF_TransacaoGado
                                    WHERE Seql_id = @id";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cattleModel = new CattleModel();
                        cattleModel.Print = (int)reader[0];
                        buyList.Add(cattleModel);
                    }
                }
            }
            return buyList;
        }
    }

}