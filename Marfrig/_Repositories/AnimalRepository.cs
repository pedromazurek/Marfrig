using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Marfrig.Repository;
using Marfrig.Models;

namespace Marfrig._Repositories
{
    public class AnimalRepository : BaseRepository, IAnimalRepository
    {
        public AnimalRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(AnimalModel animalModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO MF_Animal VALUES (@description,@price)";
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = animalModel.Description;
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = animalModel.Price;
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM MF_Animal WHERE Id = @idAnimal";
                cmd.Parameters.Add("@idAnimal", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            } 
        }
        public void Edit(AnimalModel animalModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"update MF_Animal 
                                        set Descricao=@description,Preco=@price
                                        where Id=@idAnimal";
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = animalModel.Description;
                cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = animalModel.Price;
                cmd.Parameters.Add("@idAnimal", SqlDbType.Int).Value = animalModel.IdAnimal;
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<AnimalModel> GetAll()
        {
            var animalList = new List<AnimalModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM MF_Animal order by Id asc";
                using (var reader  =  cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var animalModel = new AnimalModel();
                        animalModel.IdAnimal = (int)reader[0];
                        animalModel.Description = reader[1].ToString();
                        animalModel.Price = reader[2].ToString();
                        animalList.Add(animalModel);

                    }
                }
            }
                return animalList;
        }
        public IEnumerable<AnimalModel> GetByValue(string value)
        {
            var animalList = new List<AnimalModel>();
            int idAnimal = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string Description = value;
            using (var connection = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM MF_Animal 
                                    where Id = @idAnimal or Descricao like @description+'%' 
                                    order by Id desc";
                cmd.Parameters.Add("@idAnimal", SqlDbType.Int).Value = idAnimal;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = Description;


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var animalModel = new AnimalModel();
                        animalModel.IdAnimal = (int)reader[0];
                        animalModel.Description = reader[1].ToString();
                        animalModel.Price = reader[2].ToString();
                        animalList.Add(animalModel);

                    }
                }
            }
            return animalList;
        }
    }
}
