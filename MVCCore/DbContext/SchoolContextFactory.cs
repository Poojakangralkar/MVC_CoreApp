using System.Data.Entity.Infrastructure;

namespace University
{
    public class SchoolContextFactory : IDbContextFactory<SchoolContext>
    {
        public SchoolContext Create()
        {
            return new SchoolContext("Server=LENOVO\\SQLEXPRESS;Database=testDB;Integrated Security=True");
        }
    }
}
