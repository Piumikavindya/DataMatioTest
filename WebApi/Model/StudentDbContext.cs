using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WebApi.Model
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<StudentModel> Student {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=studentInformation;User Id=sa;Password=ppk;TrustServerCertificate=True");

        }
    }
}
