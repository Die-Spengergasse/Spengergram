using Spg.Spengergram.Api.Test.Helpers;
using Spg.Spengergram.DomainModel.Dtos;
using System.Net;

namespace Spg.Spengergram.Api.Test
{
    public class UserTests : IClassFixture<UserApiFactory>
    {
        private readonly UserApiFactory _factory;
        // Dependency injection from IClassFixture
        public UserTests(UserApiFactory factory)
        {
            _factory = factory;
        }

        [Fact()]
        public async void Should_WORK_Grrrrrrrrrrrrrrrrrr()
        {
            _factory.InitializeDatabase(db =>
            {
                var users = DatabaseUtilities.GetSeedingUsers();
                db.Users.AddRange(users);
                db.SaveChanges();

                var persistantUsers = db.Users;
            });
            var (statusCode, albums) = await _factory.GetHttpContent<List<UserDto>>("/api/users");
            Assert.Equal(HttpStatusCode.OK, statusCode);
        }
    }
}
