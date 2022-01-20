using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Registro{
public class Roles{
    [Key]

    public int RolesId { get; set;}

    public string? Fecha { get; set;}

    public string? Descripcion { get; set;}

    public string? Nombre { get; set;}

    public Roles( string? nombre)
    {
        Roles roles = this; Nombre = nombre;
    }
}
}