using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Test.Helpers
{
    public static class DatabaseUtilities 
    {
        public static UnitTestDatabase CreateDb()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite(connection)
                .Options;

            UnitTestDatabase db = new UnitTestDatabase(options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        public static void SeedDatabase(UnitTestDatabase db)
        {
            List<User> users = GetSeedingUsers();

            db.Users.AddRange(users);

            db.SaveChanges();
        }

        public static List<User> GetSeedingUsers()
        {
            return new List<User>()
            {
                new User(
                    new Guid("11111111-2222-5555-6666-999977773333"),
                    "Hans",
                    "Reinsch", 
                    new Username("hansi1234"), new EMailAddress("hans@reinsch.at")
                ),
                new User(
                    new Guid("22223333-4444-1324-6666-999977773333"),
                    "Anna",
                    "Theke",
                    new Username("hansi1234"), new EMailAddress("anna-theke@gmail.com")
                ),
                new User(
                    new Guid("33334444-7777-1234-6666-999977773333"),
                    "Axel",
                    "Schweiß",
                    new Username("hansi1234"), new EMailAddress("schweiß_axel@gmail.com")
                ),
                new User(
                    new Guid("44445555-9541-5555-2222-999944443333"),
                    "Toni",
                    "Fit",
                    new Username("hansi1234"), new EMailAddress("hans@reinsch@gmx.at")
                ),
                new User(
                    new Guid("11111111-1597-3333-9999-222277773333"),
                    "Anna",
                    "Nass",
                    new Username("hansi1234"), new EMailAddress("annnass@gmail.com")
                ),
                new User(
                    new Guid("11111111-4321-3333-9999-333377773333"),
                    "Max",
                    "Dünnsch",
                    new Username("hansi1234"), new EMailAddress("max.duensch@gmx.at")
                ),
                new User(
                    new Guid("55554444-1234-3333-9999-999977771111"),
                    "Uri",
                    "Nierer",
                    new Username("hansi1234"), new EMailAddress("urinierer@gmx.at")
                ),
            };
        }
    }
} 
