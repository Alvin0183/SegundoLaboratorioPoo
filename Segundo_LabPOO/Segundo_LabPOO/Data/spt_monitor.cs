//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Segundo_LabPOO.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class spt_monitor
    {
        public System.DateTime lastrun { get; set; }
        public int cpu_busy { get; set; }
        public int io_busy { get; set; }
        public int idle { get; set; }
        public int pack_received { get; set; }
        public int pack_sent { get; set; }
        public int connections { get; set; }
        public int pack_errors { get; set; }
        public int total_read { get; set; }
        public int total_write { get; set; }
        public int total_errors { get; set; }
    }
}
