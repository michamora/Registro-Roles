using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using BLL;

namespace BLL
{
    public class Roles
    {
        [Key]
        public string? Rolid { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }

        public Roles()
        {
            Fecha = DateTime.Now; //Tomar la fecha en tiempo real
        }

        public Roles(string? rolId, string? descripcion)
        {
            Rolid = rolId;

            Fecha = DateTime.Now;

            Descripcion = descripcion;
        }
    }
}