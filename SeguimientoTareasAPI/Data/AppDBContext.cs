using Microsoft.EntityFrameworkCore;
using SeguimientoTareasAPI.Models;

namespace SeguimientoTareasAPI.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(tb =>{

                tb.ToTable("Usuarios");

                tb.HasKey(col => col.Id);
                tb.Property(col => col.Id)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.Nombre)
                .HasMaxLength(30)
                .IsRequired();

                tb.Property(col => col.Apellido)
                .HasMaxLength(30)
                .IsRequired();

                tb.Property(col => col.Rol)
                .IsRequired();

                tb.Property(col => col.Area)
                .IsRequired();

                tb.HasIndex(col => col.Legajo)
                .IsUnique();
                tb.Property(col => col.Legajo)
                .HasMaxLength(50)
                .IsRequired();

                tb.Property(col => col.Email)
                .HasMaxLength(50)
                .IsRequired();

                tb.Property(col => col.Password)
                .HasMaxLength(50)
                .IsRequired();

                // Constrainsts para validar el Rol y el Area
                tb.ToTable(t => {
                    t.HasCheckConstraint("CK_Usuario_Area", "Area IN (0, 1, 2, 3, 4, 5)");
                    t.HasCheckConstraint("CK_Usuario_Rol", "Rol IN (1, 2, 3, 4)");
                });
  
            });

            modelBuilder.Entity<Tarea>(tb =>{
                tb.ToTable("Tareas");

                tb.HasKey(col => col.Id);
                tb.Property(col => col.Id)
                .UseIdentityColumn()
                .ValueGeneratedOnAdd();

                tb.Property(col => col.NumeroTarea)
                .HasMaxLength(50)
                .IsRequired();

                tb.HasIndex(col => col.NumeroTarea)
                .IsUnique();

                tb.Property(col => col.Titulo)
                .HasMaxLength(50)
                .IsRequired();

                tb.Property(col => col.Descripcion)
                .HasMaxLength(2000)
                .IsRequired();

                tb.Property(col => col.FechaCreacion)
                .IsRequired()
                .HasColumnType("date"); //Guarda solo la fecha

                tb.Property(col => col.FechaCierre)
                .IsRequired(false)
                .HasColumnType("date"); //Guarda solo la fecha

                tb.Property(col => col.Estado)
                .IsRequired();

                // Constrainsts para validar el Estado de la Tarea
                tb.ToTable(t => {
                    t.HasCheckConstraint("CK_Tarea_Estado", "Estado IN (1, 2, 3)");
                });
            });
        }
    }
}