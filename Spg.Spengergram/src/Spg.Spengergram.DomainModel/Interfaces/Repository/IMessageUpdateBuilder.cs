using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IMessageUpdateBuilder
    {
        Message Entity { get; set; }

        IMessageUpdateBuilder WithBody(string newBody);

        int Save();
    }
}
