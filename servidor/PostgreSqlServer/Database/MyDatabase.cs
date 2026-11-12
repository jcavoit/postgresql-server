using Microsoft.EntityFrameworkCore;
using PostgreSqlServer.Database.Entities;

namespace PostgreSqlServer.Database
{
    public class MyDatabase : DbContext
    {
        private const string DATABASE_FILENAME = "coches.db";
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            options.UseSqlite($"DataSource={baseDir}{DATABASE_FILENAME}");

        }

    }
}
