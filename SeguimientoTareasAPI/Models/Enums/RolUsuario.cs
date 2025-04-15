namespace SeguimientoTareasAPI.Models;

using System.ComponentModel;
//Enumerado sobre los roles que se le pueden asignar a un Usuario.
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
