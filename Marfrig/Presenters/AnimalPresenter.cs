using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marfrig.Models;
using Marfrig.Models.Cattle;
using Marfrig.Repository;
using Marfrig.Views;
using Marfrig.Views.Cattle;

namespace Marfrig.Presenters
{
    public class AnimalPresenter
    {
        private IAnimalView view;
        private IAnimalRepository repository;
        private BindingSource animalBindingSource;
        private IEnumerable<AnimalModel> animalList;

        public AnimalPresenter(IAnimalView view, IAnimalRepository repository)
        {
            this.animalBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchAnimal;
            this.view.AddNewEvent += AddNewAnimal;
            this.view.EditEvent += LoadSelectAnimalToEdit;
            this.view.DeleteEvent += DeleteSelectAnimal;
            this.view.SaveEvent += SaveAnimal;
            this.view.CancelEvent += CancelAction;

            this.view.SetAnimalListBindingSource(animalBindingSource);
            //Carrega todos os animais 
            LoadAllAnimalList();
            this.view.Show();
        }

     
        //Method
        private void LoadAllAnimalList()
        {
            animalList = repository.GetAll();
            animalBindingSource.DataSource = animalList;
        }

        private void SearchAnimal(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (emptyValue == false)
                animalList = repository.GetByValue(this.view.SearchValue);
            else animalList = repository.GetAll();
            animalBindingSource.DataSource = animalList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveAnimal(object? sender, EventArgs e)
        {
            var model = new AnimalModel();
            model.IdAnimal = Convert.ToInt32(view.IdAnimal);
            model.Description = view.Description;
            model.Price = view.Price;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Animal editado com sucesso";
                }
                else
                { 
                    repository.Add(model);
                    view.Message = "Animal adicionado com sucesso";
                }
                view.IsSuccessful = true;
                LoadAllAnimalList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                
            }
        }

        private void CleanViewFields()
        {
            view.IdAnimal = "0";
            view.Description = "";
            view.Price = "";
        }

        private void DeleteSelectAnimal(object? sender, EventArgs e)
        {
            try
            {
                var animal = (AnimalModel)animalBindingSource.Current;
                repository.Delete(animal.IdAnimal);
                view.IsSuccessful = true;
                view.Message = "Animal deletado com sucesso";
                LoadAllAnimalList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful= false;
                view.Message= ex.Message;
            }
        }

        private void LoadSelectAnimalToEdit(object? sender, EventArgs e)
        {
            var animal = (AnimalModel)animalBindingSource.Current;
            view.IdAnimal = animal.IdAnimal.ToString();
            view.Description = animal.Description;
            view.Price = animal.Price;
            view.IsEdit = true;
        }

        private void AddNewAnimal(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }


    }
}
