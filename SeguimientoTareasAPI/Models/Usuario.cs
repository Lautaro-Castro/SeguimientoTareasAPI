using System;

namespace SeguimientoTareasAPI.Models;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public Rol RolUsuario { get; set; }
    public Area Area { get; set; }
    public string Legajo { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
