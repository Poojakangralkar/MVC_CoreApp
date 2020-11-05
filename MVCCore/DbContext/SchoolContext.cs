using University.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace University
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(string connString) : base(connString)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
