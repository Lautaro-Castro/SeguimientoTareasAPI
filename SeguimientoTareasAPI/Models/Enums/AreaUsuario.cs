namespace SeguimientoTareasAPI.Models;

using System.ComponentModel;
//Enumerado sobre las areas que posee la empresa.
public enum AreaUsuario
{
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
