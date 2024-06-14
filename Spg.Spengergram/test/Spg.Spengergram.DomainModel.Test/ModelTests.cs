using Spg.Spengergram.DomainModel.Model;
using Spg.Spengergram.DomainModel.Test.Helpers;

namespace Spg.Spengergram.DomainModel.Test
{
    public class ModelTests
    {
        [Fact]
        public void Should_AddCommentToMessage()
        {
            // Arrange
            Message message = DatabaseUtilities.GetSeedingMessages().ElementAt(0);

            // Act
            message = message.AddComment(
                new Comment("new Comment 1", DatabaseUtilities.GetSeedingUsers().ElementAt(3)));

            // Assert
            Assert.Equal(3, message.Comments.Count());
            Assert.Equal("new Comment 1", message.Comments[2].Body);
            Assert.Equal(message, message.Comments[2].MessageNavigation);
        }

        [Fact]
        public void Should_AddCommentsToMessage()
        {
            // Arrange
            Message message = DatabaseUtilities.GetSeedingMessages().ElementAt(0);

            // Act
            message = message.AddComments(
                new List<Comment>() 
                { 
                    new Comment("new Comment 1", DatabaseUtilities.GetSeedingUsers().ElementAt(5)),
                    new Comment("new Comment 2", DatabaseUtilities.GetSeedingUsers().ElementAt(6))
                });

            // Assert
            Assert.Equal(4, message.Comments.Count());
            Assert.Equal("new Comment 1", message.Comments[2].Body);
            Assert.Equal(message, message.Comments[2].MessageNavigation);
            Assert.Equal("new Comment 2", message.Comments[3].Body);
            Assert.Equal(message, message.Comments[3].MessageNavigation);
        }

        [Fact]
        public void Should_AddMessagesToMessenger()
        {
            // Arrange
            Messenger message = DatabaseUtilities.GetSeedingMessengers().ElementAt(0);

            // Act
            message = message.AddMessages(
                new List<Message>()
                {
                    new Message("new Message 1"),
                    new Message("new Message 2")
                });

            // Assert
            Assert.Equal(9, message.Messages.Count());
            Assert.Equal("new Message 1", message.Messages[7].Body);
            Assert.Equal(message, message.Messages[7].MessengerNavigation);
            Assert.Equal("new Message 2", message.Messages[8].Body);
            Assert.Equal(message, message.Messages[8].MessengerNavigation);
        }

        [Fact]
        public void Should_AddUsersToMessenger()
        {
            // Arrange
            Messenger message = DatabaseUtilities.GetSeedingMessengers().ElementAt(0);

            // Act
            message = message.AddUsers(
                new List<User>()
                {
                    new User(new Guid("99998888-7777-6666-5555-444433332222"), "Martin", "Schrutek", new DateTime(1977, 05, 13), new Username("schrutek"), new EMailAddress("schrutek@spengergasse.at"))
                });

            // Assert
            Assert.Equal(4, message.Users.Count());
            Assert.Equal("Schrutek", message.Users[3].LastName);
            Assert.Equal(message, message.Users[3].MessengerNavigation);
        }
    }
}
