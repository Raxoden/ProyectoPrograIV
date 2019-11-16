using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public Colaborador BusquedaColaborador(int ID)
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
        public Usuario BusquedaUsuario(int ID)
        {
            try
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var query = (from C in PE.Colaborador
                                 join A in PE.Area on C.ID_Area equals A.ID_Area
                                 join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                 join U in PE.Usuario on C.ID_Colaborador equals U.ID_Colaborador
                                 where C.ID_Colaborador == ID
                                 select new Usuario
                                 {
                                     ID_Colaborador = C.ID_Colaborador,
                                     Nombre = C.Nombre,
                                     Desc_Puesto = P.Descripcion,
                                     Desc_Area = A.Descripcion,
                                     Privilegios = U.Privilegios
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
        public List<Colaborador> ConsultaColaboradores(Usuario us)
        {
            try
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    if (us.Privilegios)
                    {
                        var query = (from C in PE.Colaborador
                                     join A in PE.Area on C.ID_Area equals A.ID_Area
                                     join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                     where P.Descripcion == "Gerente" || A.Descripcion.Contains("RECURSOS HUMANOS")
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
                    else
                    {
                        var query = (from C in PE.Colaborador
                                     join A in PE.Area on C.ID_Area equals A.ID_Area
                                     join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                     where A.Descripcion == us.Desc_Area
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<Usuario> ConsultaUsuarios(Usuario us)
        {
            try
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var query = (from C in PE.Colaborador
                                    join A in PE.Area on C.ID_Area equals A.ID_Area
                                    join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                                    join U in PE.Usuario on C.ID_Colaborador equals U.ID_Colaborador
                                    where U.ID_Colaborador != us.ID_Colaborador
                                    select new Usuario
                                    {
                                        ID_Colaborador = C.ID_Colaborador,
                                        Nombre = C.Nombre,
                                        Desc_Puesto = P.Descripcion,
                                        Desc_Area = A.Descripcion,
                                        Privilegios = U.Privilegios
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
        public List<String> BusquedaArea(Usuario us)
        {
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities()) {
                if (us.Privilegios)
                {
                    var query = (from C in PE.Colaborador
                                join A in PE.Area on C.ID_Area equals A.ID_Area
                                orderby A.Descripcion
                                select A.Descripcion).Distinct().ToList();
                    return query;
                } else
                {
                    var query = (from C in PE.Colaborador
                                 join A in PE.Area on C.ID_Area equals A.ID_Area
                                 where C.ID_Colaborador == us.ID_Colaborador
                                 orderby A.Descripcion
                                 select A.Descripcion).ToList();
                    return query;
                }
            }
        }
        public List<String> BusquedaPuesto(string DescArea)
        {
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                var query = (from C in PE.Colaborador
                             join P in PE.Puesto on C.ID_Puesto equals P.ID_Puesto
                             join A in PE.Area on C.ID_Area equals A.ID_Area
                             where A.Descripcion == DescArea
                             orderby P.Descripcion
                             select P.Descripcion).Distinct().ToList();
                return query;
            }
        }
        public List<String> BusquedaGenero()
        {
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                var query = (from C in PE.Colaborador
                             select C.Genero).Distinct().ToList();
                return query;
            }
        }
        
        #region Usuarios
        public bool RegistrarUsuario(int ID, string Contrasenna, bool Privilegio)
        {
            if (BusquedaUsuario(ID) == null)
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    DataBase.Usuario usuario = new DataBase.Usuario();
                    usuario.ID_Colaborador = ID;
                    usuario.Contrasenna = Contrasenna;
                    usuario.Privilegios = Privilegio;
                    PE.Usuario.Add(usuario);
                    PE.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarUsuario(int ID, string Contrasenna, bool Privilegio)
        {
            if (BusquedaUsuario(ID) == null)
            {
                return false;
            } else
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    DataBase.Usuario usuario = PE.Usuario.Where(x => x.ID_Colaborador == ID).FirstOrDefault();
                    usuario.Contrasenna = Contrasenna;
                    usuario.Privilegios = Privilegio;
                    PE.SaveChanges();
                    return true;
                }
            }
        }
        public bool EliminarUsuario(int ID)
        {
            if (BusquedaUsuario(ID) == null)
            {
                return false;
            }
            else
            {
                using(SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    DataBase.Usuario usuario = PE.Usuario.Where(x => x.ID_Colaborador == ID).FirstOrDefault();
                    PE.Usuario.Remove(usuario);
                    PE.SaveChanges();
                    return true;
                }
            }
        }
        #endregion

        #region Colaboradores
        public bool RegistrarColaborador(int ID, string Nombre, string Genero, int Edad, DateTime Fecha_Nacimiento, DateTime Fecha_Ingreso, string Desc_Puesto, string Desc_Area)
        {
            if (BusquedaColaborador(ID) == null)
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var idA = (from A in PE.Area
                              where A.Descripcion == Desc_Area
                              select A.ID_Area).ToList().FirstOrDefault();
                    var idP = (from P in PE.Puesto
                              where P.Descripcion == Desc_Puesto
                              select P.ID_Puesto).ToList().FirstOrDefault();
                    DataBase.Colaborador colaborador = new DataBase.Colaborador();
                    colaborador.ID_Colaborador = ID;
                    colaborador.Nombre = Nombre;
                    colaborador.Genero = Genero;
                    colaborador.Edad = Edad;
                    colaborador.Fecha_Nacimiento = Fecha_Nacimiento;
                    colaborador.Fecha_Ingreso = Fecha_Ingreso;
                    colaborador.ID_Puesto = idP;
                    colaborador.ID_Area = idA;
                    PE.Colaborador.Add(colaborador);
                    PE.SaveChanges();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ActualizarColaborador(int ID, string Nombre, string Genero, int Edad, DateTime Fecha_Nacimiento, DateTime Fecha_Ingreso, string Desc_Puesto, string Desc_Area)
        {
            if (BusquedaColaborador(ID) == null)
            {
                return false;
            }
            else
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var idA = (from A in PE.Area
                               where A.Descripcion == Desc_Area
                               select A.ID_Area).ToList().FirstOrDefault();
                    var idP = (from P in PE.Puesto
                               where P.Descripcion == Desc_Puesto
                               select P.ID_Puesto).ToList().FirstOrDefault();
                    DataBase.Colaborador colaborador = PE.Colaborador.Where(x => x.ID_Colaborador == ID).FirstOrDefault();
                    colaborador.ID_Colaborador = ID;
                    colaborador.Nombre = Nombre;
                    colaborador.Genero = Genero;
                    colaborador.Edad = Edad;
                    colaborador.Fecha_Nacimiento = Fecha_Nacimiento;
                    colaborador.Fecha_Ingreso = Fecha_Ingreso;
                    colaborador.ID_Puesto = idP;
                    colaborador.ID_Area = idA;
                    PE.SaveChanges();
                    return true;
                }
            }
        }
        public bool EliminarColaborador(int ID)
        {
            if (BusquedaColaborador(ID) == null)
            {
                return false;
            }
            else
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    if (BusquedaUsuario(ID) == null)
                    {
                        DataBase.Colaborador colaborador = PE.Colaborador.Where(x => x.ID_Colaborador == ID).FirstOrDefault();
                        PE.Colaborador.Remove(colaborador);
                        PE.SaveChanges();
                        return true;
                    } else
                    {
                        MessageBox.Show("Para eliminar un colaborador con usuario, debe de eliminar primero el usuario correspondiente.");
                        return false;
                    }
                }
            }
        }
        #endregion
    }
}
