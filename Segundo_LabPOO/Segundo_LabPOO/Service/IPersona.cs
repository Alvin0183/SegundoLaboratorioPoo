using Segundo_LabPOO.Data;
using Segundo_LabPOO.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_LabPOO.Service
{
   interface IPersona 
    {
        void Guardar(persona persona);

        List<persona> ListofDataofTablepersona();


    }
}
