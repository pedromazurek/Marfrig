using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Marfrig.Models
{
    public class AnimalModel
    {
        private int idAnimal;
        private string? description;
        private string? price;
        [DisplayName("Id Animal")]
        public int IdAnimal { get => idAnimal; set => idAnimal = value; }
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Descrição obrigatória")]
        [StringLength(20,MinimumLength = 1, ErrorMessage = "Descrição Inválida")]
        public string? Description { get => description; set => description = value; }
        [DisplayName("Preço")]
        [Required(ErrorMessage = "Preço obrigatória")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Preço Inválida")]
        public string? Price { get => price; set => price = value; }
    }

    public class GetAnimalModel
    {
        private int idAnimal;
        private string animal;

        public int IdAnimal { get => idAnimal; set => idAnimal = value; }
        public string Animal { get => animal; set => animal = value; }
    }
}
