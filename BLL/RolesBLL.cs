using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DAL;

namespace BLL
{
    public class RolesBLL
    {
    public static bool Insertar(Roles roles)
    {
            bool confirmacion = false;

            using (var contexto = new Contexto())

            {
                contexto.Roles?.Add(roles);
                confirmacion = contexto.SaveChanges() > 0;
            }

            return confirmacion;
        }

        public static List<Roles> GetLista()
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Roles.ToList ();
            }
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try{
                var roles = contexto.Roles.Find(id);

                if (roles != null)
                {
                    contexto.Roles.Remove(roles);
                    paso = contexto.SaveChanges() >0;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
              contexto.Dispose();
            }
            return paso;
        }
    

        public static bool Editar(Roles roles)
        {
            bool confirmar = false;

            return confirmar;
        }
    }
}