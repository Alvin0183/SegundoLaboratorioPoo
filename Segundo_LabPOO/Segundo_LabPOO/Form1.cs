using Segundo_LabPOO.Data;
using Segundo_LabPOO.Negocio;
using Segundo_LabPOO.Repository;
using Segundo_LabPOO.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_LabPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona prn = new persona();
            prn.nombrePersona = txtnombre.Text;
            prn.descripcionPersona = txtdescripcion.Text;
            prn.edadPersona = int.Parse(txtedad.Text);
            ClsPersona clspersona = new ClsPersona();
            clspersona.Guardar(prn);
            clspersona.Guardar(prn);

            MessageBox.Show("Guardado en la base de datos");

            ClsPersona persona = new ClsPersona();
            clspersona.Guardar(prn);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormPersona frmpersona = new FormPersona();
            frmpersona.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
