using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace BackEnd
{
    public class FuncionesDB
    {
        public Boolean Validacion(int us, string pa)
        {
            try
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var query = from U in PE.Usuario 
                                where U.ID_Colaborador == us & 
                                U.Contrasenna == pa select U.Privilegios;
                    return Convert.ToBoolean(query.ToList().FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public object Consulta()
        {
            {
                try
                {
                    using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                    {
                        var query = from C in PE.Colaborador
                                    join A in PE.Area on C.ID_Area equals A.ID_Area
                                    join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                    select new Colaborador
                                    {
                                        ID_Colaborador = C.ID_Colaborador,
                                        Nombre = C.Nombre,
                                        Genero = Convert.ToString(C.Genero),
                                        Edad = Convert.ToInt32(C.Edad),
                                        Fecha_Nacimiento = Convert.ToDateTime(C.Fecha_Nacimiento),
                                        Fecha_Ingreso = Convert.ToDateTime(C.Fecha_Ingreso),
                                        Desc_Puesto = P.Descripcion,
                                        Desc_Area = A.Descripcion
                                    };
                        return query.ToList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }
        }

    }
}
