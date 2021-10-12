using Segundo_LabPOO.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_LabPOO.Negocio
{
    class ClsPersona
    {

        public persona GUARDADON(persona pers)
        {
            guardar(pers);
            return null;
        }
        public List<persona> listafinal()
        {
            var list = listofDataofTablepersona();
            return list;

        }

    }
}
