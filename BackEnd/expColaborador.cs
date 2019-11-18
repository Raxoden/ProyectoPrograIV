using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    /// <summary>
    /// Clase utilizada para manejar y exportar los datos originales de Colaborador
    /// </summary>
    class expColaborador
    {
        public int ID_Colaborador { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public System.DateTime Fecha_Ingreso { get; set; }
        public int ID_Puesto { get; set; }
        public int ID_Area { get; set; }
    }
}
