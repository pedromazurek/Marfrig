using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marfrig.Views;
using Marfrig.Models;
using Marfrig._Repositories;
using Marfrig.Repository;
using Marfrig.Views.Cattle;
using Marfrig.Models.Cattle;

namespace Marfrig.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private IAnimalRepository animal;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowAnimalView += ShowAnimalViews;
            this.mainView.ShowCattleView += ShowCattleViews;
            
        }

        private void ShowAnimalViews(object? sender, EventArgs e)
        {
            IAnimalView view = AnimalView.GetInstance((MainView)mainView);
            IAnimalRepository repository = new AnimalRepository(sqlConnectionString);
            new AnimalPresenter(view, repository);
        }
        private void ShowCattleViews(object? sender, EventArgs e)
        {
            ICattleView view = CattleView.GetInstance((MainView)mainView);
            ICattleRepository repository = new CattleRepository(sqlConnectionString);
            new CattlePresenter(view, repository);
        }

    }
}
