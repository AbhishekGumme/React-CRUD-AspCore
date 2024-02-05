using Microsoft.EntityFrameworkCore;

namespace ReactAspCrud.Models
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TAFC468\\SQLEXPRESS; Initial Catalog=ReactAsp; User Id=DESKTOP-TAC468; password=Abhishek@123; TrustServerCertificate= True");
        }
    }
}
