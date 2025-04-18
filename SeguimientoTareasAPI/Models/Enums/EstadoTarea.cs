namespace SeguimientoTareasAPI.Models;

using System.ComponentModel;
//Enum que representa el estado actual de la tarea.
public enum EstadoTarea
{
    [Description("Pendiente")]
    Pendiente = 1,
    [Description("En Progreso")]
    EnProgreso = 2,
    [Description("Completada")]
    Completada = 3
}
