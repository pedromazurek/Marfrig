using Marfrig.Models.Cattle;
using Marfrig.Presenters;
//using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marfrig.Views.Cattle
{
    public partial class CattleView : Form, ICattleView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;


        public CattleView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            tabSelectCattle.TabPages.Remove(TabDetails);
            btnClose1.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvent()
        {

            btnProcurar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //botão Adicionar
            btnAdicionar.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabSelectCattle.TabPages.Remove(TabBuyList);
                tabSelectCattle.TabPages.Add(TabDetails);
                comboBox1.DisplayMember = "cattleBreederAll";
                comboBox1.ValueMember = "id";
                comboBox2.DisplayMember = "Animal";
                comboBox2.ValueMember = "idAnimal";

                TabDetails.Text = "Adicionar nova compra";
            };
            //botão Editar
            btnEditar.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabSelectCattle.TabPages.Remove(TabBuyList);
                    tabSelectCattle.TabPages.Add(TabDetails);
                    comboBox1.DisplayMember = "cattleBreederAll";
                    comboBox1.ValueMember = "id";
                    comboBox2.DisplayMember = "Animal";
                    comboBox2.ValueMember = "idAnimal";

                    TabDetails.Text = "editar uma compra";
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            //botão Salvar
            btnSalvar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabSelectCattle.TabPages.Remove(TabDetails);
                    tabSelectCattle.TabPages.Add(TabBuyList);
                }
                MessageBox.Show(Message);
            };
            //botão Deletar
            btnDeletar.Click += delegate
            {
                var result = MessageBox.Show("Tem certeza que gostaria de deletar o item selecionado?", "Aviso",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    if (isSuccessful)
                    {
                        MessageBox.Show(Message);
                    }
                    else
                    {
                        MessageBox.Show(Message);
                    }
                }

            };
            //botão Cancelar
            btnCancelar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabSelectCattle.TabPages.Remove(TabDetails);
                tabSelectCattle.TabPages.Add(TabBuyList);
            };
            //botão Imprimir (Report)
            btnImprimir.Click += delegate
            {
                PrintEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            //botão Voltar pagina
            btnVoltar.Click += delegate
            {
                PgPreviousEvent?.Invoke(this, EventArgs.Empty);
            };
            //botão Proxima pagina
            btnPrx.Click += delegate
            {
                PgNextEvent?.Invoke(this, EventArgs.Empty);
            };


        }
        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string CattleBreeder
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        public string SelectDeliveryDate
        {
            get { return txtDeliveryDate.Text; }
            set { txtDeliveryDate.Text = value; }
        }

        public string Quantity
        {
            get { return txtQtd.Text; }
            set { txtQtd.Text = value; }
        }
        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {

            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Animal
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler PrintEvent;
        public event EventHandler PgPreviousEvent;
        public event EventHandler PgNextEvent;

        public void SetBuyListBindingSource(BindingSource buyList)
        {
            dataGridView1.DataSource = buyList;
        }
        public void SetCattleListBindingSource(BindingSource cattleList)
        {
            comboBox1.DataSource = cattleList;
        }

        public void SetAnimalListBindingSource(BindingSource animalList)
        {
            comboBox2.DataSource = animalList;

        }

        private static CattleView instance;
        public static CattleView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CattleView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }


    }
}
