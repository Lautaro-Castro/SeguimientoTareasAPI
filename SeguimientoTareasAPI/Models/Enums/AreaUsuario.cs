namespace SeguimientoTareasAPI.Models;

using System.ComponentModel;
// Enum usado por simplicidad actual. Puede convertirse en tabla relacional si se necesita dinamismo.
public enum AreaUsuario
{
    [Description("Desarrollo")]
    Administrador = 0,
    [Description("Desarrollo")]
    Desarrollo = 1,
    [Description("Testing")]
    Testing = 2,
    [Description("Base de Datos")]
    DataBase = 3,
    [Description("Infraestructura")]
    Infraestructura = 4,
    [Description("Soporte Técnico")]
    Soporte = 5
}
