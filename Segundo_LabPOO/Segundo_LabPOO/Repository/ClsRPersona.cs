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

        public void guardar(persona persona)
        {
            using (almacendepersonasEntities conexiombd = new almacendepersonasEntities())
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
                        MessageBox.Show("SE GUARDO CON EXITO");
                    }
                    else
                    {
                        MessageBox.Show("NOSE PUEDE GUARDAR, POR QUE ES MENOR DE EDAD");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("OCURRIO UN ERROR");
                }
            }

        }

        public List<persona> listofDataofTablepersona()
        {
            using (almacendepersonasEntities conexiombd = new almacendepersonasEntities())
            {
                List<persona> lista = conexiombd.persona.ToList();

                return lista;
            }


        }

    }
}
