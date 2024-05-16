using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.Application.Test.Helpers 
{
    public static class DatabaseUtilities
    {
        public static SqLiteDatabase CreateDb()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite(connection)
                .Options;

            SqLiteDatabase db = new SqLiteDatabase(options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }
    }
}
