using Spg.Spengergram.DomainModel.Test.Helpers;

namespace Spg.Spengergram.DomainModel.Test;

public class DatabaseTests
{
    [Fact]
    public void Should_CreateAndSeedDatabase()
    {
        using (UnitTestDatabase db = DatabaseUtilities.CreateMemoryDb())
        {
            // Arrange
            var users = DatabaseUtilities.GetSeedingUsers();

            // Act
            db.Users.AddRange(users);
            db.SaveChanges();

            // Assert
            Assert.Equal(7, db.Users.Count());
        }
    }

    [Fact]
    public void Should_CreateAndSeedDatabaseFile()
    {
        using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
        {
            // Arrange
            var users = DatabaseUtilities.GetSeedingUsers();

            // Act
            db.Users.AddRange(users);
            db.SaveChanges();

            // Assert
            Assert.Equal(7, db.Users.Count());
        }
    }
}