using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    class Colaborador {


        public int ID_Colaborador { get; set; }
        public string Nombre { get; set; }
        public char Genero { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Desc_Puesto { get; set; }
        public string Desc_Area { get; set; }

    }
}
