using Spg.Spengergram.DomainModel.Test.Helpers;
using Spg.Spengergram.Infrastructure;

namespace Spg.Spengergram.DomainModel.Test;

public class DatabaseTests
{
    [Fact]
    public void ShouldCreateAndSeedDatabase()
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