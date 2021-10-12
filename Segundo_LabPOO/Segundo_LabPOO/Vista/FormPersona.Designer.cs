
namespace Segundo_LabPOO.Vista
{
    partial class FormPersona
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
            this.CUADROLIST = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlistapersonas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CUADROLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // CUADROLIST
            // 
            this.CUADROLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CUADROLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Edad,
            this.Descripcion});
            this.CUADROLIST.Location = new System.Drawing.Point(43, 83);
            this.CUADROLIST.Name = "CUADROLIST";
            this.CUADROLIST.Size = new System.Drawing.Size(443, 221);
            this.CUADROLIST.TabIndex = 0;
            this.CUADROLIST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CUADROLIST_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // txtlistapersonas
            // 
            this.txtlistapersonas.AutoSize = true;
            this.txtlistapersonas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlistapersonas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlistapersonas.Location = new System.Drawing.Point(43, 32);
            this.txtlistapersonas.Name = "txtlistapersonas";
            this.txtlistapersonas.Size = new System.Drawing.Size(157, 28);
            this.txtlistapersonas.TabIndex = 1;
            this.txtlistapersonas.Text = "Lista de Personas";
            this.txtlistapersonas.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(543, 316);
            this.Controls.Add(this.txtlistapersonas);
            this.Controls.Add(this.CUADROLIST);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            ((System.ComponentModel.ISupportInitialize)(this.CUADROLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CUADROLIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label txtlistapersonas;
    }
}