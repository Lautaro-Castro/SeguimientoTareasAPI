namespace SeguimientoTareasAPI.Models;

using System.ComponentModel;
// Enum usado por simplicidad actual. Puede convertirse en tabla relacional si se necesita dinamismo.
public enum RolUsuario
{
    [Description("Administrador")]
    Admin = 1,
    [Description("Gerente")]
    Gerente = 2,
    [Description("Lider de Equipo")]
    TeamLeader = 3,
    [Description("Empleado")]
    Empleado = 4
}
