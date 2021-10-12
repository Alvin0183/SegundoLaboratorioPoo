using Segundo_LabPOO.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_LabPOO.Repository
{
    class ClsRPersona
    {

        public void Guardar(persona persona)
        {
            using (almacendepersonasEntities1 conexiombd = new almacendepersonasEntities1())
            {
                try
                {
                    persona per = new persona();
                    per.nombrePersona = persona.nombrePersona;
                    per.edadPersona = persona.edadPersona;
                    per.descripcionPersona = persona.descripcionPersona;

                    if (per.edadPersona >= 18)
                    {
                        conexiombd.persona.Add(per);
                        conexiombd.SaveChanges();
                        MessageBox.Show("Los datos fueron registrados exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten mayores de edad");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("algo salio mal");
                }
            }

        }

        public List<persona> listofDataofTablepersona()
        {
            using (almacendepersonasEntities1 conexiombd = new almacendepersonasEntities1())
            {
                List<persona> lista = conexiombd.persona.ToList();

                return lista;
            }


        }

    }
}
