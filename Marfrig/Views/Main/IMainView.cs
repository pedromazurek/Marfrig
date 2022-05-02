using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marfrig.Views
{
    public interface IMainView
    {

        event EventHandler ShowAnimalView;
        event EventHandler ShowCompraGadoView;
        event EventHandler ShowCompraGadoIemView;
        event EventHandler ShowPecuaristaView;
        event EventHandler ShowRelatorioView;
        event EventHandler ShowCattleView;

    }
}
