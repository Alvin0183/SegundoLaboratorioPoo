using Segundo_LabPOO.Data;
using Segundo_LabPOO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_LabPOO.Negocio
{
    class ClsPersona : ClsRPersona
    {

        public persona guardar(persona pers)
        {
            Guardar(pers);
            return null;
        }
        public List<persona> listafinal()
        {
            var list = listofDataofTablepersona();
            
            return list;

        }

        
        
        
    }
}
