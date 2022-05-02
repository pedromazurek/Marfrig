using Marfrig.Models;
using Marfrig.Models.Cattle;
using Marfrig.Repository;
using Marfrig.Views;
using Marfrig.Views.Cattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig.Presenters
{
    public class CattlePresenter
    {
        private ICattleView view;
        private ICattleRepository repository;
        private BindingSource buyBindingSource;
        private BindingSource cattleBindingSource;
        private BindingSource animalBindingSource;
        private IEnumerable<CattleModel> buyList;
        private IEnumerable<GetCattleModel> cattleList;
        private IEnumerable<GetAnimalModel> animalList;

        public CattlePresenter(ICattleView view, ICattleRepository repository)
        {
            this.buyBindingSource = new BindingSource();
            this.cattleBindingSource = new BindingSource();
            this.animalBindingSource = new BindingSource();
            
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchBuy;
            this.view.AddNewEvent += AddNewBuy;
            this.view.EditEvent += LoadSelectBuyToEdit;
            this.view.DeleteEvent += DeleteSelectBuy;
            this.view.SaveEvent += SaveBuy;
            this.view.CancelEvent += CancelAction;
            this.view.PrintEvent += PrintEvent;
            this.view.PgPreviousEvent += PreviousEvent;
            this.view.PgNextEvent += PgNextEvent;


            this.view.SetBuyListBindingSource(buyBindingSource);
            this.view.SetAnimalListBindingSource(animalBindingSource);

            //Carrega todos as compras 
            LoadAllBuyList();
            this.view.Show();
        }

        private void PgNextEvent(object? sender, EventArgs e)
        {
            buyList = repository.GetAllPaginated();
            buyBindingSource.DataSource = buyList;
        }

        private void PreviousEvent(object? sender, EventArgs e)
        {
            buyList = repository.GetAll();
            buyBindingSource.DataSource = buyList;
        }

        private void PrintEvent(object? sender, EventArgs e)
        {
            this.view.SetBuyListBindingSource(buyBindingSource);
            List<CattleModel> cattle = (List<CattleModel>)buyBindingSource.DataSource;

            try
            {
                repository.PrintCattle(cattle);
                view.Message = "Itens impressos com sucesso";
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            LoadAllBuyList();
        }
        private void LoadAllBuyList()
        {
            buyList = repository.GetAll();
            buyBindingSource.DataSource = buyList;
        }

        private void SearchBuy(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (emptyValue == false)
                buyList = repository.GetByValue(this.view.SearchValue);
            else buyList = repository.GetAll();
            buyBindingSource.DataSource = buyList;

            this.view.Show();
        }

        private void AddNewBuy(object? sender, EventArgs e)
        {
            this.view.SetCattleListBindingSource(cattleBindingSource);

            LoadCattleList();
            LoadAnimalList();
            view.IsEdit = false;
            this.view.Show();
        }

        private void LoadAnimalList()
        {
            animalList = repository.GetAllAnimals();
            animalBindingSource.DataSource = animalList;
        }

        private void LoadCattleList()
        {
            cattleList = repository.GetAllCattles();
            cattleBindingSource.DataSource = cattleList;
        }

        private void DeleteSelectBuy(object? sender, EventArgs e)
        {
            var cattle = (CattleModel)buyBindingSource.Current;
            var cattle1 = repository.GetPrintAvailable(cattle.Id);

            foreach (var item in cattle1)
            {
                if (item.Print == 1)
                {
                    view.Message = "Item já impresso. Não é possivel deletar";
                    view.IsSuccessful = false;
                }
                else
                {
                    try
                    {
                        //var cattle = (CattleModel)buyBindingSource.Current;
                        repository.Delete(cattle.Id);
                        view.IsSuccessful = true;
                        view.Message = "Compra deletado com sucesso";
                        LoadAllBuyList();
                        view.IsSuccessful = true;
                    }
                    catch (Exception ex)
                    {
                        view.IsSuccessful = false;
                        view.Message = ex.Message;
                    }
                }
            }
           
        }

        private void LoadSelectBuyToEdit(object? sender, EventArgs e)
        {
            var cattle = (CattleModel)buyBindingSource.Current;
            var cattle1 = repository.GetPrintAvailable(cattle.Id);

            foreach (var item in cattle1)
            {
                if(item.Print == 1)
                {
                    view.Message = "Item já impresso. Não é possivel editar";
                    view.IsSuccessful = false;
                }
                else
                {
                    this.view.SetCattleListBindingSource(cattleBindingSource);

                    LoadCattleList();
                    LoadAnimalList();
                    view.CattleBreeder = cattle.CattleBreeder;
                    view.Quantity = cattle.Quantity.ToString();
                    view.SelectDeliveryDate = cattle.SelectDeliveryDate.ToString();
                    view.IsSuccessful = true;
                    view.IsEdit = true;
                    this.view.Show();
                }
            }
        }

        private void SaveBuy(object? sender, EventArgs e)
        {
            var model = new AddCattleModel();

            model.CattleBreeder = view.CattleBreeder;
            model.Animal = Convert.ToString(view.Animal);
            model.Quantity = Convert.ToInt32(view.Quantity);
            model.SelectDeliveryDate = Convert.ToDateTime(view.SelectDeliveryDate);
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {

                    repository.Edit(model);
                    view.Message = "Compra editada com sucesso";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Compra adicionada com sucesso";
                }
                view.IsSuccessful = true;
                LoadAllBuyList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.Quantity = "0";
            view.SelectDeliveryDate = "";
        }
    }
}

