namespace Marfrig.Views.Cattle
{
    partial class CattleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSelectCattle = new System.Windows.Forms.TabControl();
            this.TabBuyList = new System.Windows.Forms.TabPage();
            this.btnPrx = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabDetails = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cattleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabSelectCattle.SuspendLayout();
            this.TabBuyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cattleModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.Location = new System.Drawing.Point(777, 133);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(777, 93);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(777, 51);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(732, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 22);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnClose1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 62);
            this.panel1.TabIndex = 13;
            // 
            // btnClose1
            // 
            this.btnClose1.Location = new System.Drawing.Point(874, 3);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(56, 22);
            this.btnClose1.TabIndex = 3;
            this.btnClose1.Text = "X";
            this.btnClose1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de compra de gados";
            // 
            // tabSelectCattle
            // 
            this.tabSelectCattle.Controls.Add(this.TabBuyList);
            this.tabSelectCattle.Controls.Add(this.TabDetails);
            this.tabSelectCattle.Location = new System.Drawing.Point(0, 68);
            this.tabSelectCattle.Name = "tabSelectCattle";
            this.tabSelectCattle.SelectedIndex = 0;
            this.tabSelectCattle.Size = new System.Drawing.Size(868, 382);
            this.tabSelectCattle.TabIndex = 14;
            // 
            // TabBuyList
            // 
            this.TabBuyList.Controls.Add(this.btnPrx);
            this.TabBuyList.Controls.Add(this.btnVoltar);
            this.TabBuyList.Controls.Add(this.btnImprimir);
            this.TabBuyList.Controls.Add(this.btnProcurar);
            this.TabBuyList.Controls.Add(this.txtSearch);
            this.TabBuyList.Controls.Add(this.dataGridView1);
            this.TabBuyList.Controls.Add(this.btnDeletar);
            this.TabBuyList.Controls.Add(this.btnAdicionar);
            this.TabBuyList.Controls.Add(this.btnEditar);
            this.TabBuyList.Location = new System.Drawing.Point(4, 24);
            this.TabBuyList.Name = "TabBuyList";
            this.TabBuyList.Padding = new System.Windows.Forms.Padding(3);
            this.TabBuyList.Size = new System.Drawing.Size(860, 354);
            this.TabBuyList.TabIndex = 0;
            this.TabBuyList.Text = "Lista";
            this.TabBuyList.UseVisualStyleBackColor = true;
            // 
            // btnPrx
            // 
            this.btnPrx.Location = new System.Drawing.Point(777, 289);
            this.btnPrx.Name = "btnPrx";
            this.btnPrx.Size = new System.Drawing.Size(58, 23);
            this.btnPrx.TabIndex = 15;
            this.btnPrx.Text = ">";
            this.btnPrx.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(709, 289);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 23);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(777, 182);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurar.Location = new System.Drawing.Point(606, 22);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 12;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(8, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(592, 23);
            this.txtSearch.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(695, 285);
            this.dataGridView1.TabIndex = 10;
            // 
            // TabDetails
            // 
            this.TabDetails.Controls.Add(this.comboBox2);
            this.TabDetails.Controls.Add(this.comboBox1);
            this.TabDetails.Controls.Add(this.label6);
            this.TabDetails.Controls.Add(this.label3);
            this.TabDetails.Controls.Add(this.txtQtd);
            this.TabDetails.Controls.Add(this.label7);
            this.TabDetails.Controls.Add(this.btnCancelar);
            this.TabDetails.Controls.Add(this.btnSalvar);
            this.TabDetails.Controls.Add(this.txtDeliveryDate);
            this.TabDetails.Controls.Add(this.label4);
            this.TabDetails.Location = new System.Drawing.Point(4, 24);
            this.TabDetails.Name = "TabDetails";
            this.TabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.TabDetails.Size = new System.Drawing.Size(860, 354);
            this.TabDetails.TabIndex = 1;
            this.TabDetails.Text = "Detalhes";
            this.TabDetails.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(40, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 23);
            this.comboBox1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(40, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pecuarista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Animal";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(188, 94);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(139, 23);
            this.txtQtd.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(145, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(40, 298);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeliveryDate.Location = new System.Drawing.Point(40, 152);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(139, 23);
            this.txtDeliveryDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Entrega";
            // 
            // cattleModelBindingSource
            // 
            this.cattleModelBindingSource.DataSource = typeof(Marfrig.Models.Cattle.GetCattleModel);
            // 
            // animalRepositoryBindingSource
            // 
            this.animalRepositoryBindingSource.DataSource = typeof(Marfrig._Repositories.AnimalRepository);
            // 
            // CattleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.tabSelectCattle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Name = "CattleView";
            this.Text = "Cattle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSelectCattle.ResumeLayout(false);
            this.TabBuyList.ResumeLayout(false);
            this.TabBuyList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabDetails.ResumeLayout(false);
            this.TabDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cattleModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Button btnClose;
        private Panel panel1;
        private Button btnClose1;
        private Label label1;
        private TabControl tabSelectCattle;
        private TabPage TabBuyList;
        private TabPage TabDetails;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnProcurar;
        private Label label4;
        private TextBox txtDeliveryDate;
        private BindingSource animalRepositoryBindingSource;
        private Button btnSalvar;
        protected Label label7;
        private Button btnCancelar;
        private TextBox txtQtd;
        protected Label label3;
        private Label label6;
        private BindingSource cattleModelBindingSource;
        private ComboBox comboBox1;
        private Button btnImprimir;
        private ComboBox comboBox2;
        private Button btnVoltar;
        private Button btnPrx;
    }
}