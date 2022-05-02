namespace Marfrig.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCompraGado = new System.Windows.Forms.Button();
            this.BtnAnimal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCompraGado);
            this.panel1.Controls.Add(this.BtnAnimal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 492);
            this.panel1.TabIndex = 0;
            // 
            // BtnCompraGado
            // 
            this.BtnCompraGado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCompraGado.Location = new System.Drawing.Point(6, 40);
            this.BtnCompraGado.Name = "BtnCompraGado";
            this.BtnCompraGado.Size = new System.Drawing.Size(194, 35);
            this.BtnCompraGado.TabIndex = 1;
            this.BtnCompraGado.Text = "Compra Gado";
            this.BtnCompraGado.UseVisualStyleBackColor = true;
            // 
            // BtnAnimal
            // 
            this.BtnAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnimal.Location = new System.Drawing.Point(6, 122);
            this.BtnAnimal.Name = "BtnAnimal";
            this.BtnAnimal.Size = new System.Drawing.Size(194, 35);
            this.BtnAnimal.TabIndex = 0;
            this.BtnAnimal.Text = "Animal";
            this.BtnAnimal.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 492);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button BtnAnimal;
        private Button BtnCompraGado;
    }
}