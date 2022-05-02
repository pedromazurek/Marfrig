using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Marfrig.Models.Cattle
{
    public class CattleModel
    {


        private int id;
        private string cattleBreeder;
        private DateTime selectDeliveryDate;
        private decimal amount;
        private string quantity;
        private int print;

        [DisplayName("Id")]
        public int Id { get => id; set => id = value; }
        [DisplayName("Pecuarista")]
        [Required(ErrorMessage = "Descrição obrigatória")]
        public string CattleBreeder { get => cattleBreeder; set => cattleBreeder = value; }
        [DisplayName("Data de Entrega")]
        //[DisplayFormat(DataFormatString  = "DD/MM/YYYY")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Data Inválida")]
        public DateTime SelectDeliveryDate { get => selectDeliveryDate; set => selectDeliveryDate = value; }
        [DisplayName("Quantidade")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(20, MinimumLength = 1,ErrorMessage = "Descrição Inválida")]
        [Range(1, 9999)]
        public string Quantity { get => quantity; set => quantity = value; }
        [DisplayName("Valor Total")]
        public decimal Amount { get => amount; set => amount = value; }
        [Browsable(false)]
        public int Print { get => print; set => print = value; }
    }

    public class GetCattleModel
    {
        private int id;
        private string cattleBreederAll;

        [DisplayName("Id")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Pecuaristas")]
        public string CattleBreederAll { get => cattleBreederAll; set => cattleBreederAll = value; }
        
    }

    public class AddCattleModel
    {
        private int id;
        private string cattleBreeder;
        private string animal;
        private int quantity;
        private DateTime selectDeliveryDate;

        public int Id { get => id; set => id = value; }
        public string CattleBreeder { get => cattleBreeder; set => cattleBreeder = value; }
        public string Animal { get => animal; set => animal = value; }
        [Required(ErrorMessage ="Campo Obrigatório")]
        [Range(1, 9999)]
        public int Quantity { get => quantity; set => quantity = value; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.DateTime)]
        [Range(typeof(DateTime), "01/01/1900", "31/12/9999")]
        public DateTime SelectDeliveryDate { get => selectDeliveryDate; set => selectDeliveryDate = value; }
    }

    public class EditCattleModel
    {
        private int id;
        private string cattleBreeder;
        private string animal;
        private int quantity;
        private DateTime selectDeliveryDate;

        public int Id { get => id; set => id = value; }
        public string CattleBreeder { get => cattleBreeder; set => cattleBreeder = value; }
        public string Animal { get => animal; set => animal = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime SelectDeliveryDate { get => selectDeliveryDate; set => selectDeliveryDate = value; }
    }


}
