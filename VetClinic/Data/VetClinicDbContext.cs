using Microsoft.EntityFrameworkCore;
using VetClinic.Models;

namespace VetClinic.Data
{
    /// <summary>
    /// Контекст (взаимодействие с бд).
    /// </summary>
    public class VetClinicDbContext:DbContext 
    {
        public VetClinicDbContext(DbContextOptions<VetClinicDbContext> options)
            : base(options) { }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Human> Humans { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Human>().UseTpcMappingStrategy();
        }
    }
}
