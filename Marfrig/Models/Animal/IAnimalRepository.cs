using Marfrig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig.Repository
{
    public interface IAnimalRepository
    {
        void Add(AnimalModel animalModel);
        void Edit(AnimalModel animalModel);
        void Delete(int id);
        IEnumerable<AnimalModel> GetAll();
        IEnumerable<AnimalModel> GetByValue(string value);
    }
}
