using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Repository
{
    public interface IMessageFilterBuilder : IEntityFilterBuilder<Message>
    {
        new IQueryable<Message> EntityList { get; set; }
        new IQueryable<Message> Build();
    }
}
