using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL;

public class HospitalContext : DbContext  
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Doctor>().HasData(Doctor._Doctors);
        modelBuilder.Entity<Patient>().HasData(Patient._Patients);
    }
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Issue> Issues => Set<Issue>();

    public HospitalContext (DbContextOptions options) : base(options)
    {
        
    }

}
