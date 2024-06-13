using Microsoft.EntityFrameworkCore;
using StudentManagerWeb.Models;

namespace StudentManagerWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {    
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<LoanType> loanTypes { get; set; }
    }
}
