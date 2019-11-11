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
                    var query = (from U in PE.Usuario 
                                where U.ID_Colaborador == us & 
                                U.Contrasenna == pa select U.ID_Colaborador).ToList();
                    Console.WriteLine();
                    if (query.FirstOrDefault() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Colaborador Busqueda(int ID)
        {
            try
            {

                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var query = (from C in PE.Colaborador
                                 join A in PE.Area on C.ID_Area equals A.ID_Area
                                 join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                 where C.ID_Colaborador == ID
                                 select new Colaborador
                                 {
                                     ID_Colaborador = C.ID_Colaborador,
                                     Nombre = C.Nombre,
                                     Genero = C.Genero,
                                     Edad = C.Edad,
                                     Fecha_Nacimiento = C.Fecha_Nacimiento.ToString(),
                                     Fecha_Ingreso = C.Fecha_Ingreso.ToString(),
                                     Desc_Puesto = P.Descripcion,
                                     Desc_Area = A.Descripcion
                                 }).ToList().FirstOrDefault();
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Colaborador> Consulta()
        {
            try
            {

                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var query = (from C in PE.Colaborador
                                join A in PE.Area on C.ID_Area equals A.ID_Area
                                join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                select new Colaborador
                                {
                                    ID_Colaborador = C.ID_Colaborador,
                                    Nombre = C.Nombre,
                                    Genero = C.Genero,
                                    Edad = C.Edad,
                                    Fecha_Nacimiento = C.Fecha_Nacimiento.ToString(),
                                    Fecha_Ingreso = C.Fecha_Ingreso.ToString(),
                                    Desc_Puesto = P.Descripcion,
                                    Desc_Area = A.Descripcion
                                }).ToList();
                    return query;
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
