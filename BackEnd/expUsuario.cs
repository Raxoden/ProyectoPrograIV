using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    /// <summary>
    /// Clase utilizada para manejar y exportar los datos originales de Usuario
    /// </summary>
    class expUsuario
    {
        public int ID_Usuario { get; set; }
        public int ID_Colaborador { get; set; }
        public bool Privilegios { get; set; }
    }
}
