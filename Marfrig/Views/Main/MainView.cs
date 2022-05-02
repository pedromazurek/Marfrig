using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marfrig.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            BtnAnimal.Click+= delegate { ShowAnimalView?.Invoke(this, EventArgs.Empty); };
            BtnCompraGado.Click += delegate { ShowCattleView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowAnimalView;
        public event EventHandler ShowCompraGadoView;
        public event EventHandler ShowCompraGadoIemView;
        public event EventHandler ShowPecuaristaView;
        public event EventHandler ShowRelatorioView;
        public event EventHandler ShowCattleView;
    }
}
