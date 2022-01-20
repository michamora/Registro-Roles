using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Registro;

public class RolesBLL
{
    public static bool Insertar(Roles roles)
    {
        bool paso = false;
        Contexto contexto = new Contexto();

        try{
            contexto.Roles.Add(roles);
            paso = contexto.SaveChanges() > 0;
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

    public static bool Eliminar(int id)
    {
        bool paso = false;
        Contexto contexto = new Contexto();

         try{

             var roles = contexto.Roles.Find(id);

             if (roles != null)
             {
                 contexto.Roles.Remove(roles);
                 paso = contexto.SaveChanges() > 0;
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

    internal static bool Eliminar(object p)
    {
        throw new NotImplementedException();
    }
    public static bool Existe(int id)
    {
        Contexto contexto = new Contexto();
        bool encontrado = false;
  
        try{
  
            encontrado = contexto.Roles.Any(e => e.RolesId == id);
            
        }
        catch (Exception)
        {
            throw;
        }
        finally 
        {
            contexto.Dispose();
        }
        return encontrado;

    }
}