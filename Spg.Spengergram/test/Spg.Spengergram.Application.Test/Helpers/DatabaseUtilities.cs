using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Application.Test.Helpers
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
                    new DateTime(1991, 03, 01), 
                    new Username("hansi1234"), new EMailAddress("hans@reinsch.at")
                ) { Evaluation = 6 },
                new User(
                    new Guid("22223333-4444-1324-6666-999977773333"),
                    "Anna",
                    "Theke",
                    new DateTime(1995, 12, 05),
                    new Username("hansi1234"), new EMailAddress("anna-theke@gmail.com")
                ) { Evaluation = 5 },
                new User(
                    new Guid("33334444-7777-1234-6666-999977773333"),
                    "Axel",
                    "Schwei�",
                    new DateTime(1981, 05, 12),
                    new Username("hansi1234"), new EMailAddress("schwei�_axel@gmail.com")
                ) { Evaluation = 3 },
                new User(
                    new Guid("44445555-9541-5555-2222-999944443333"),
                    "Toni",
                    "Fit",
                    new DateTime(1977, 09, 22),
                    new Username("hansi1234"), new EMailAddress("hans@reinsch@gmx.at")
                ) { Evaluation = 2 },
                new User(
                    new Guid("11111111-1597-3333-9999-222277773333"),
                    "Anna",
                    "Nass",
                    new DateTime(2005, 01, 03),
                    new Username("hansi1234"), new EMailAddress("annnass@gmail.com")
                ) { Evaluation = 10 },
                new User(
                    new Guid("11111111-4321-3333-9999-333377773333"),
                    "Max",
                    "D�nnsch",
                    new DateTime(2002, 10, 15),
                    new Username("hansi1234"), new EMailAddress("max.duensch@gmx.at")
                ) { Evaluation = 9 },
                new User(
                    new Guid("55554444-1234-3333-9999-999977771111"),
                    "Uri",
                    "Nierer",
                    new DateTime(2012, 06, 28),
                    new Username("hansi1234"), new EMailAddress("urinierer@gmx.at")
                ) { Evaluation = 10 },
            };
        }
    }
}
