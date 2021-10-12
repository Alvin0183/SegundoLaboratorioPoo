
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
            this.columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CUADROLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // CUADROLIST
            // 
            this.CUADROLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CUADROLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columna1,
            this.columna2,
            this.columna3,
            this.columna4});
            this.CUADROLIST.Location = new System.Drawing.Point(43, 83);
            this.CUADROLIST.Name = "CUADROLIST";
            this.CUADROLIST.Size = new System.Drawing.Size(443, 221);
            this.CUADROLIST.TabIndex = 0;
            this.CUADROLIST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CUADROLIST_CellContentClick);
            // 
            // ID
            // 
            this.columna1.HeaderText = "ID";
            this.columna1.Name = "ID";
            // 
            // Nombre
            // 
            this.columna2.HeaderText = "Nombre";
            this.columna2.Name = "Nombre";
            // 
            // Edad
            // 
            this.columna3.HeaderText = "Edad";
            this.columna3.Name = "Edad";
            // 
            // Descripcion
            // 
            this.columna4.HeaderText = "Descripcion";
            this.columna4.Name = "Descripcion";
            // 
            // txtlistapersonas
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "txtlistapersonas";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Personas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(543, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CUADROLIST);
            this.Name = "FormPersona";
            this.Text = "FormPersona";
            ((System.ComponentModel.ISupportInitialize)(this.CUADROLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CUADROLIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna4;
        private System.Windows.Forms.Label label1;

    }
}