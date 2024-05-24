using Spg.Spengergram.Application.Test.Helpers;
using Spg.Spengergram.Application.UseCases.UserStories.Queries;
using Spg.Spengergram.DomainModel.Dtos;
using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.Repository.Builders;
using Spg.Spengergram.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Application.Test
{
    public class UserTests
    {
        [Fact]
        public void Should_Get3Users_When_FirstNameContainsAN()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                GetUserFilteredModel model = new GetUserFilteredModel(
                        new DomainModel.Queries.GetUserFilteredQuery("firstname ct an"));

                // Act
                GetUserFilteredHandler handler = new GetUserFilteredHandler(
                    new ReadOnlyUserRepository(db, new UserFilterBuilder(db.Users)));
                IQueryable<UserDto> result = handler.Handle(model, CancellationToken.None).Result;

                // Assert
                Assert.Equal(3, result.Count());
            }
        }

        [Fact]
        public void Should_Get1Users_When_LastNameContainsTH()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                GetUserFilteredModel model = new GetUserFilteredModel(
                        new DomainModel.Queries.GetUserFilteredQuery("lastname ct th"));

                // Act
                GetUserFilteredHandler handler = new GetUserFilteredHandler(
                    new ReadOnlyUserRepository(db, new UserFilterBuilder(db.Users)));
                IQueryable<UserDto> result = handler.Handle(model, CancellationToken.None).Result;

                // Assert
                Assert.Equal(1, result.Count());
            }
        }

        [Fact]
        public void Should_Get4Users_When_EvaluationGreaterThan5()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                GetUserFilteredModel model = new GetUserFilteredModel(
                        new DomainModel.Queries.GetUserFilteredQuery("evaluation gt 5"));

                // Act
                GetUserFilteredHandler handler = new GetUserFilteredHandler(
                    new ReadOnlyUserRepository(db, new UserFilterBuilder(db.Users)));
                IQueryable<UserDto> result = handler.Handle(model, CancellationToken.None).Result;

                // Assert
                Assert.Equal(4, result.Count());
            }
        }

        [Fact]
        public void Should_Get2Users_When_BirthdateBetween()
        {
            using (UnitTestDatabase db = DatabaseUtilities.CreateDb())
            {
                // Arrange
                DatabaseUtilities.SeedDatabase(db);
                GetUserFilteredModel model = new GetUserFilteredModel(
                        new DomainModel.Queries.GetUserFilteredQuery("birthdate bw 2000.01.01 2010.12.31"));

                // Act
                GetUserFilteredHandler handler = new GetUserFilteredHandler(
                    new ReadOnlyUserRepository(db, new UserFilterBuilder(db.Users)));
                IQueryable<UserDto> result = handler.Handle(model, CancellationToken.None).Result;

                // Assert
                Assert.Equal(2, result.Count());
            }
        }
    }
}
