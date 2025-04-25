using System;

namespace SeguimientoTareasAPI.Models;

public class Tarea
{
    public int Id { get; set; }
    public string NumeroTarea { get; set; } = string.Empty;
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get;} = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public DateTime? FechaCierre { get; set; } 
    public EstadoTarea Estado { get; set; } = EstadoTarea.Pendiente;
    public int UsuarioId { get; set; }
}

