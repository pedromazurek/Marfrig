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
    public partial class AnimalView : Form, IAnimalView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public AnimalView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvent();
            tabControl1.TabPages.Remove(TabDetails);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvent()
        {
            //botão Procurar
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
                tabControl1.TabPages.Remove(TabAnimalList);
                tabControl1.TabPages.Add(TabDetails);
                TabDetails.Text = "Adicionar novo animal";

            };
            //botão Editar
            btnEditar.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabAnimalList);
                tabControl1.TabPages.Add(TabDetails);
                TabDetails.Text = "editar um animal";
            };
            //botão Salvar
            btnSalvar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(TabDetails);
                    tabControl1.TabPages.Add(TabAnimalList);
                }
                MessageBox.Show(Message);
            };
            //botão Deletar
            btnDeletar.Click += delegate
            {
                var result = MessageBox.Show("Tem certeza que gostaria de deletar o item selecionado?","Aviso",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this,EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };
            //botão Cancelar
            btnCancelar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(TabDetails);
                tabControl1.TabPages.Add(TabAnimalList);
            };

        }

        public string IdAnimal
        {
            get { return txtIdAnimal.Text; }
            set { txtIdAnimal.Text = value; }
        }
        public string Description
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }
        public string Price
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
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

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;


        public void SetAnimalListBindingSource(BindingSource animalList)
        {
            dataGridView.DataSource = animalList;
        }

        // tratativa para abrir uma view só;
        private static AnimalView instance;
        public static AnimalView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AnimalView();
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
