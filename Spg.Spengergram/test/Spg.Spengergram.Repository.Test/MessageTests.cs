using Spg.Spengergram.DomainModel.Exceptions.Repository;
using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.Repository.Repositories;
using Spg.Spengergram.Repository.Test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Repository.Test
{
    public class MessageTests
    {
        [Fact]
        public void Should_CreateOneMessage()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                Message message = new("Nam liber tempor cum soluta nobis eleifend option " +
                    "congue nihil imperdiet doming id quod mazim placerat facer possim " +
                    "assum. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed " +
                    "diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam " +
                    "erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation " +
                    "ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.");

                // Act
                WritableMessageRepository repository = new WritableMessageRepository(db);
                repository.Create(message);

                // Assert
                Assert.Equal(4, db.Messages.Count());
            }
        }

        [Fact]
        public void Should_UpdateOneMessage()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                Message message = db.Messages.ElementAt(1);
                string newBody = "At vero eos et accusam et justo duo dolores et ea rebum. " +
                "Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum " +
                "dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing " +
                "elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore " +
                "magna aliquyam erat, sed diam voluptua. At vero eos et accusam et " +
                "justo duo dolores et ea rebum_updated";

                // Act
                WritableMessageRepository repository = new WritableMessageRepository(db);
                repository
                    .UpdateBuilder(message)
                    .WithBody(newBody)
                    .Save();

                // Assert
                Assert.Contains("updated", message.Body);
            }
        }

        [Fact]
        public void Should_RemoveOneMessage_WhenFound()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                Message existingMessage = db.Messages.ElementAt(1);

                // Act
                WritableMessageRepository repository = new WritableMessageRepository(db);
                repository.Delete(new MessageId(2));

                // Assert
                Assert.Equal(2, existingMessage.Id.Value);
                Assert.Equal(2, db.Messages.Count());
            }
        }

        [Fact]
        public void Should_ThrowException_WhenMessageForDeleteNotFound()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                Message existingMessage = db.Messages.ElementAt(1);

                // Act
                WritableMessageRepository repository = new WritableMessageRepository(db);

                // Assert
                WriteRepositoryException ex = Assert.Throws<WriteRepositoryException>(
                    () => repository.Delete(new MessageId(4711))
                );
                Assert.Equal("Delete failed!", ex.Message);
            }
        }
    }
}
