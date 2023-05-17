using AkwadratDesign.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Data.SqlClient;

namespace AkwadratDesign.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectFirm> ProjectFirms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Project>()
            .HasMany(e => e.Firms)
            .WithMany(e => e.Projects)
            .UsingEntity<ProjectFirm>(
             l => l.HasOne<Firm>(e => e.Firm).WithMany(e => e.ProjectFirms).HasForeignKey(e => e.FirmsId),
             r => r.HasOne<Project>(e => e.Project).WithMany(e => e.ProjectFirms).HasForeignKey(e => e.ProjectsId));

        }

    }
}
