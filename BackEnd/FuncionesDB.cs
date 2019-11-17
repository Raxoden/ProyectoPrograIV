using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;
using SpreadsheetLight;

namespace BackEnd
{
    /// <summary>
    /// Clase que almacena todas las funciones que se ejecutan en el programa.
    /// </summary>
    public class FuncionesDB
    {
        /// <summary>
        /// Verifica si el usuario existe y si sus credenciales son correctas.
        /// </summary>
        /// <param name="us">El ID del colaborador que se utiliza como nombre de usuario.</param>
        /// <param name="pa">La contraseña del colaborador con la cual ingresa a sus usuario.</param>
        /// <returns>Si las credenciales estan correctas devuelve verdadero, devuelve falso cuando son incorrectas.</returns>
        public Boolean Validacion(int us, string pa)
        {
            try
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
                {
                    var query = (from U in PE.Usuario 
                                where U.ID_Colaborador == us & 
                                U.Contrasenna == pa select U.ID_Usuario).ToList().FirstOrDefault();
                    Console.WriteLine();
                    if (query > 0)
                    {
                        registrarEntrada(Convert.ToInt32(query));
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
        /// <summary>
        /// Busca un colaborador y devuelve el objeto con la información necesaria.
        /// </summary>
        /// <param name="ID">Recibe el ID del colaborador.</param>
        /// <returns>Si se encuentra se devuelve verdadero, si no se encuentra devolvera falso</returns>
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
        /// <summary>
        /// Busca un usuario y devuelve el objeto con la información necesaria.
        /// </summary>
        /// <param name="ID">Recibe el ID del colaborador.</param>
        /// <returns>Si se encuentra se devuelve verdadero, si no se encuentra devolvera falso</returns>
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
                                     ID_Usuario = U.ID_Usuario,
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
        /// <summary>
        /// Hace la consulta de todos los colaboradores.
        /// </summary>
        /// <returns>Devuelve todos los colaboradores que sean Gerentes o del departamento de Recursos Humanos</returns>
        public List<Colaborador> ConsultaGerentes()
        {
            try
            {
                using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Hace la consulta de todos los colaboradores.
        /// </summary>
        /// <param name="us">Se recibe el Usuario</param>
        /// <returns>Devuelve todos los colaboradores si se cuenta con privilegios,
        /// si no se cuenta con privilegios se devuelven los colaboradores de la misma Area que el usuario.</returns>
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

        #region Excel
        public bool ExportarExcel()
        {
            SLDocument slDocumento = new SLDocument();
            SLStyle slEstilo = new SLStyle();
            int indxFila = 2;
            slEstilo.Font.FontSize = 12;
            slEstilo.Font.Bold = true;
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                var col = (from C in PE.Colaborador
                           select new expColaborador
                           {
                               ID_Colaborador = C.ID_Colaborador,
                               Nombre = C.Nombre,
                               Genero = C.Genero,
                               Edad = C.Edad,
                               Fecha_Nacimiento = C.Fecha_Nacimiento,
                               Fecha_Ingreso = C.Fecha_Ingreso,
                               ID_Area = C.ID_Area,
                               ID_Puesto = C.ID_Puesto
                           }).ToList();

                var usu = (from U in PE.Usuario
                           select new expUsuario
                           {
                               ID_Usuario = U.ID_Usuario,
                               ID_Colaborador = U.ID_Colaborador,
                               Privilegios = U.Privilegios
                           }).ToList();

                var are = (from A in PE.Area
                           select new expArea
                           {
                               ID_Area = A.ID_Area,
                               Descripcion = A.Descripcion
                           }).ToList();

                var pue = (from P in PE.Puesto
                           select new expPuesto
                           {
                               ID_Puesto = P.ID_Puesto,
                               Descripcion = P.Descripcion
                           }).ToList();

                slDocumento.SetCellValue(1, 1, "ID_Colaborador");
                slDocumento.SetCellValue(1, 2, "Nombre");
                slDocumento.SetCellValue(1, 3, "Genero");
                slDocumento.SetCellValue(1, 4, "Edad");
                slDocumento.SetCellValue(1, 5, "Fecha_Nacimiento");
                slDocumento.SetCellValue(1, 6, "Fecha_Ingreso");
                slDocumento.SetCellValue(1, 7, "Area");
                slDocumento.SetCellValue(1, 8, "Puesto");

                foreach (expColaborador colaborador in col)
                {
                    slDocumento.SetCellValue(indxFila, 1, colaborador.ID_Colaborador);
                    slDocumento.SetCellValue(indxFila, 2, colaborador.Nombre);
                    slDocumento.SetCellValue(indxFila, 3, colaborador.Genero);
                    slDocumento.SetCellValue(indxFila, 4, colaborador.Edad);
                    slDocumento.SetCellValue(indxFila, 5, colaborador.Fecha_Nacimiento);
                    slDocumento.SetCellValue(indxFila, 6, colaborador.Fecha_Ingreso);
                    slDocumento.SetCellValue(indxFila, 7, colaborador.ID_Area);
                    slDocumento.SetCellValue(indxFila, 8, colaborador.ID_Puesto);
                    indxFila++;
                }
                indxFila--;
                SLTable tbl = slDocumento.CreateTable("A1", "H"+indxFila);
                tbl.SetTableStyle(SLTableStyleTypeValues.Medium1);
                slDocumento.InsertTable(tbl);

                slDocumento.SetCellValue(1, 10, "ID_Usuario");
                slDocumento.SetCellValue(1, 11, "ID_Colaborador");
                slDocumento.SetCellValue(1, 12, "Contrasenna");
                slDocumento.SetCellValue(1, 13, "Privilegios");

                indxFila = 2;
                foreach (expUsuario usuario in usu)
                {
                    slDocumento.SetCellValue(indxFila, 10, usuario.ID_Usuario);
                    slDocumento.SetCellValue(indxFila, 11, usuario.ID_Colaborador);
                    slDocumento.SetCellValue(indxFila, 12, "*****");
                    slDocumento.SetCellValue(indxFila, 13, usuario.Privilegios);
                    indxFila++;
                }
                indxFila--;
                tbl = slDocumento.CreateTable("J1", "M" + indxFila);
                tbl.SetTableStyle(SLTableStyleTypeValues.Medium1);
                slDocumento.InsertTable(tbl);

                slDocumento.SetCellValue(1, 15, "ID_Area");
                slDocumento.SetCellValue(1, 16, "Descripcion");

                indxFila = 2;
                foreach (expArea area in are)
                {
                    slDocumento.SetCellValue(indxFila, 15, area.ID_Area);
                    slDocumento.SetCellValue(indxFila, 16, area.Descripcion);
                    indxFila++;
                }
                indxFila--;
                tbl = slDocumento.CreateTable("O1", "P" + indxFila);
                tbl.SetTableStyle(SLTableStyleTypeValues.Medium1);
                slDocumento.InsertTable(tbl);

                slDocumento.SetCellValue(1, 18, "ID_Puesto");
                slDocumento.SetCellValue(1, 19, "Descripcion");

                indxFila = 2;
                foreach (expPuesto puesto in pue)
                {
                    slDocumento.SetCellValue(indxFila, 18, puesto.ID_Puesto);
                    slDocumento.SetCellValue(indxFila, 19, puesto.Descripcion);
                    indxFila++;
                }
                indxFila--;
                tbl = slDocumento.CreateTable("R1", "S" + indxFila);
                tbl.SetTableStyle(SLTableStyleTypeValues.Medium1);
                slDocumento.InsertTable(tbl);

                slDocumento.AutoFitColumn("A", "S");
                slDocumento.SaveAs(@"C:\Users\andre\Desktop\ListadoColaboradores.xlsx");
                MessageBox.Show("Datos exportados exitosamente al documento 'ListadoColaboradores.xlsx'");
            }
            return true;
        }
        #endregion

        #region Bitacora
        public void registrarEntrada(int ID)
        {
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                DataBase.Bitacora bitacora = new DataBase.Bitacora();
                bitacora.ID_Usuario = ID;
                bitacora.Fecha = DateTime.Today;
                bitacora.Hora_Entrada = DateTime.Now.TimeOfDay;
                bitacora.Hora_Salida = DateTime.Now.TimeOfDay;
                PE.Bitacora.Add(bitacora);
                PE.SaveChanges();
            }
        }
        public void registrarSalida(int ID)
        {
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                DataBase.Bitacora bitacora = PE.Bitacora.Where(x => x.ID_Usuario == ID && x.Fecha == DateTime.Today).FirstOrDefault();
                bitacora.Hora_Salida = DateTime.Now.TimeOfDay;
                PE.SaveChanges();
            }
        }
        #endregion

        #region Reporte
        public void registrarEvento(int usu, int col, int eve)
        {
            using (SistemaPlanillaEntities PE = new SistemaPlanillaEntities())
            {
                DataBase.Reporte reporte = new DataBase.Reporte();
                reporte.ID_Usuario = usu;
                reporte.ID_Colaborador = col;
                reporte.ID_Evento = eve;
                reporte.Fecha = DateTime.Today;
                reporte.Hora = DateTime.Now.TimeOfDay;
                PE.Reporte.Add(reporte);
                PE.SaveChanges();
            }
        }
        #endregion
    }
}
