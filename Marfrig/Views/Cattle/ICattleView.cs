using Marfrig.Models.Cattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig.Views.Cattle
{
    public interface ICattleView : IBuyCattleView
    {
        string Id { get; set; }
        string CattleBreeder { get; set; }
        string SelectDeliveryDate { get; set; }
        

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler CancelEvent;
        event EventHandler PrintEvent;
        event EventHandler SaveEvent;
        event EventHandler EditEvent;
        event EventHandler PgPreviousEvent;
        event EventHandler PgNextEvent;

        void SetCattleListBindingSource(BindingSource cattleList);
        void SetBuyListBindingSource(BindingSource buyList);
        void SetAnimalListBindingSource(BindingSource animalList);
        void Show();
        
    }

    public interface IBuyCattleView
    {
        string Animal { get; set; }
        string Quantity { get; set; }
       
    }
}
