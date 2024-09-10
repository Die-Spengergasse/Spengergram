using Spg.Spengergram.Application.Test.Helpers;
using Spg.Spengergram.Application.UseCases.UserStories.Commands;
using Spg.Spengergram.Application.UseCases.UserStories.Queries;
using Spg.Spengergram.DomainModel.Commands;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Queries;
using Spg.Spengergram.Repository.Builders;
using Spg.Spengergram.Repository.Repositories;

namespace Spg.Spengergram.Application.Test
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
                CreateMessageModel model = new CreateMessageModel(
                    new CreateMessageCommand(
                        new Guid("11112222-1111-1111-1111-111122221111"), 
                        "New Message", 
                        db.Users.ElementAt(0).ToDto()));

                // Act
                CreateMessageHandler handler = new CreateMessageHandler(
                    new WritableMessageRepository(db), new ReadOnlyMessengerRepository(db));
                handler.Handle(model, CancellationToken.None);

                // Assert
                Assert.Equal(8, db.Messengers.ElementAt(0).Messages.Count());
            }
        }

        [Fact]
        public void Should_GetAllMessages_OfOneMessanger()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                GetMessageModel model = new GetMessageModel(
                    new GetMessageQuery(
                        new Guid("11112222-1111-1111-1111-111122221111")));

                // Act
                GetMessageHandler handler = new GetMessageHandler(
                    new ReadOnlyMessageRepository(db, new MessageFilterBuilder(db.Messages)));
                IQueryable<MessageDto> result = handler.Handle(model, CancellationToken.None)
                    .Result;

                // Assert
                Assert.Equal(7, result.Count());
            }
        }
    }
}
