using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig.Models.Cattle
{
    public interface ICattleRepository
    {
        void Add(AddCattleModel model);
        void Edit(AddCattleModel cattleModel);
        void Delete(int id);
        void PrintCattle(List<CattleModel> model);
        IEnumerable<CattleModel> GetAll();
        IEnumerable<CattleModel> GetByValue(string value);
        IEnumerable<GetCattleModel> GetAllCattles();
        IEnumerable<GetAnimalModel> GetAllAnimals();
        IEnumerable<CattleModel> GetAllPaginated();
        IEnumerable<CattleModel> GetPrintAvailable(int id);

    }
}
