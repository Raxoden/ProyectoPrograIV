using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    /// <summary>
    /// Clase utilizada para manipular y mostrar facilmente los datos de Colaborador
    /// </summary>
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public int ID_Colaborador { get; set; }
        public string Nombre { get; set; }
        public string Desc_Puesto { get; set; }
        public string Desc_Area { get; set; }
        public bool Privilegios { get; set; }
    }
}
