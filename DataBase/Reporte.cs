//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reporte
    {
        public int ID_Reporte { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora { get; set; }
        public int ID_Evento { get; set; }
        public int ID_Usuario { get; set; }
        public int ID_Colaborador { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        public virtual Evento Evento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
