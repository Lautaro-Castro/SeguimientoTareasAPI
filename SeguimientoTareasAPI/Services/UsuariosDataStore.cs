using System;
using SeguimientoTareasAPI.Models;

namespace SeguimientoTareasAPI.Services;

public class UsuariosDataStore
{
    public List<Usuario> Usuarios{ get; set; }

    public static UsuariosDataStore Current {get;} = new UsuariosDataStore();
    public UsuariosDataStore()
    {
        Usuarios = new List<Usuario>(){
            new Usuario(){
                Id = 1,
                Nombre = "Jorge",
                Apellido = "Ramirez",
                Rol = RolUsuario.Empleado,
                Area = AreaUsuario.Desarrollo,
                Legajo = "D100",
                Email = "jorgeramirez@gmail.com",
                Password = "12345"
            },
            new Usuario(){
                Id = 2,
                Nombre = "Sofia",
                Apellido = "Perez",
                Rol = RolUsuario.TeamLeader,
                Area = AreaUsuario.Desarrollo,
                Legajo = "D101",
                Email = "sofiperez@gmail.com",
                Password = "12345"
            },
            new Usuario(){
                Id = 3,
                Nombre = "Marcos",
                Apellido = "Gimenez",
                Rol = RolUsuario.TeamLeader,
                Area = AreaUsuario.Desarrollo,
                Legajo = "D102",
                Email = "sofiperez@gmail.com",
                Password = "12345"
            },
            new Usuario(){
                Id = 4,
                Nombre = "Antonio",
                Apellido = "Margaretti",
                Rol = RolUsuario.Gerente,
                Area = AreaUsuario.Desarrollo,
                Legajo = "D103",
                Email = "antomarga@gmail.com",
                Password = "12345"
            },
            new Usuario(){
                Id = 1,
                Nombre = "Martina",
                Apellido = "Mangani",
                Rol = RolUsuario.Admin,
                Area = AreaUsuario.Desarrollo,
                Legajo = "D104",
                Email = "mmangani@gmail.com",
                Password = "12345"
            },
            new Usuario(){
                Id = 1,
                Nombre = "Lucas",
                Apellido = "Novillo",
                Rol = RolUsuario.Empleado,
                Area = AreaUsuario.Testing,
                Legajo = "T102",
                Email = "lnovillo@gmail.com",
                Password = "12345"
            }
        };

    }
}
