using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Test.Helpers
{
    public static class DatabaseUtilities 
    {
        public static UnitTestDatabase CreateDb()
        {
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite("Data Source = .\\..\\..\\..\\..\\..\\Spengergram.db")
                .Options;

            UnitTestDatabase db = new UnitTestDatabase(options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        public static UnitTestDatabase CreateMemoryDb()
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
            List<Messenger> messengers = GetSeedingMessengers();
            db.Messengers.AddRange(messengers);
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
                    new Username("hansi1234"),
                    new EMailAddress("hans@reinsch.at")
                ) { Evaluation = 6 },
                new User(
                    new Guid("22223333-4444-1324-6666-999977773333"),
                    "Anna",
                    "Theke",
                    new DateTime(1995, 12, 05),
                    new Username("hansi1234"),
                    new EMailAddress("anna-theke@gmail.com")
                ) { Evaluation = 5 },
                new User(
                    new Guid("33334444-7777-1234-6666-999977773333"),
                    "Axel",
                    "Schweiß",
                    new DateTime(1981, 05, 12),
                    new Username("hansi1234"),
                    new EMailAddress("schweiß_axel@gmail.com")
                ) { Evaluation = 3 },
                new User(
                    new Guid("44445555-9541-5555-2222-999944443333"),
                    "Toni",
                    "Fit",
                    new DateTime(1977, 09, 22),
                    new Username("hansi1234"),
                    new EMailAddress("hans@reinsch@gmx.at")
                ) { Evaluation = 2 },
                new User(
                    new Guid("11111111-1597-3333-9999-222277773333"),
                    "Anna",
                    "Nass",
                    new DateTime(2005, 01, 03),
                    new Username("hansi1234"),
                    new EMailAddress("annnass@gmail.com")
                ) { Evaluation = 10 },
                new User(
                    new Guid("11111111-4321-3333-9999-333377773333"),
                    "Max",
                    "Dünnsch",
                    new DateTime(2002, 10, 15),
                    new Username("hansi1234"),
                    new EMailAddress("max.duensch@gmx.at")
                ) { Evaluation = 9 },
                new User(
                    new Guid("55554444-1234-3333-9999-999977771111"),
                    "Uri",
                    "Nierer",
                    new DateTime(2012, 06, 28),
                    new Username("hansi1234"),
                    new EMailAddress("urinierer@gmx.at")
                ) { Evaluation = 10 },
            };
        }

        public static List<Message> GetSeedingMessages()
        {
            return new List<Message>()
            {
                new Message("Lorem ipsum dolor sit amet, consetetur sadipscing elitr, " +
                "sed diam nonumy eirmod tempor invidunt ut labore et dolore magna " +
                "aliquyam erat, sed diam voluptua")
                    .AddComment(new Comment("nice!", GetSeedingUsers().ElementAt(6)))
                    .AddComment(new Comment("like :)", GetSeedingUsers().ElementAt(5))),
                new Message("At vero eos et accusam et justo duo dolores et ea rebum. " +
                "Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum " +
                "dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing " +
                "elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore " +
                "magna aliquyam erat, sed diam voluptua. At vero eos et accusam et " +
                "justo duo dolores et ea rebum")
                    .AddComment(new Comment("Comment 1", GetSeedingUsers().ElementAt(5)))
                    .AddComment(new Comment("Comment 2", GetSeedingUsers().ElementAt(2)))
                    .AddComment(new Comment("Comment 3", GetSeedingUsers().ElementAt(3))),
                new Message("Hello World!"),
                new Message("Ut wisi enim ad minim veniam, quis nostrud exerci tation " +
                "ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat."),
                new Message("Duis autem vel eum iriure dolor in hendrerit in vulputate " +
                "velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis " +
                "at vero eros et accumsan et iusto odio dignissim qui blandit praesent " +
                "luptatum zzril delenit augue duis dolore te feugait nulla facilisi."),
                new Message("Duis autem vel eum iriure dolor in hendrerit in vulputate " +
                "velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis" +
                "_xxxxx."),
                new Message("Stet clita kasd gubergren, no sea takimata sanctus est Lorem " +
                "ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing " +
                "elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna " +
                "aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores " +
                "et ea rebum."),
                new Message("Lorem ipsum dolor sit amet,"),
                new Message("Stet clita kasd gubergren, no sea takimata sanctus."),
                new Message("At vero eos et accusam et justo duo dolores et ea rebum."),
            };
        }
        public static List<Messenger> GetSeedingMessengers()
        {
            return new List<Messenger>()
            {
                new Messenger(new Guid("11112222-1111-1111-1111-111122221111"))
                    .AddMessages(new List<Message>() 
                    {
                        GetSeedingMessages().ElementAt(0),
                        GetSeedingMessages().ElementAt(1),
                        GetSeedingMessages().ElementAt(2),
                        GetSeedingMessages().ElementAt(3),
                        GetSeedingMessages().ElementAt(4),
                        GetSeedingMessages().ElementAt(5),
                        GetSeedingMessages().ElementAt(6),
                    })
                    .AddUsers(new List<User>() 
                    {
                        GetSeedingUsers().ElementAt(0),
                        GetSeedingUsers().ElementAt(1), 
                        GetSeedingUsers().ElementAt(2), 
                    }),
                new Messenger(new Guid("22221111-2222-2222-2222-222211112222"))
                    .AddMessages(new List<Message>()
                    {
                        GetSeedingMessages().ElementAt(7),
                        GetSeedingMessages().ElementAt(8),
                        GetSeedingMessages().ElementAt(9)
                    })
                    .AddUsers(new List<User>()
                    {
                        GetSeedingUsers().ElementAt(3),
                        GetSeedingUsers().ElementAt(4),
                        GetSeedingUsers().ElementAt(5),
                        GetSeedingUsers().ElementAt(6),
                    })
            };
        }
    }
} 
