using Segundo_LabPOO.Negocio;
using Segundo_LabPOO.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_LabPOO.Vista
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }
        private void Frmpersona_Load(object sender, EventArgs e)
        {
            ClsPersona clspersona = new ClsPersona();
            var person = clspersona.listafinal();
            foreach (var interar in person)
            {
                CUADROLIST.Rows.Add(interar.idpersona, interar.nombrePersona, interar.edadPersona, interar.descripcionPersona);


            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CUADROLIST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
