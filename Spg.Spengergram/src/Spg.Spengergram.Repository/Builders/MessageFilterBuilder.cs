using Spg.Spengergram.DomainModel.Interfaces.Repository;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Repository.Builders
{
    public class MessageFilterBuilder : IEntityFilterBuilder<Message>, IMessageFilterBuilder
    {
        public IQueryable<Message> EntityList { get; set; }

        public MessageFilterBuilder(IQueryable<Message> entityList)
        {
            EntityList = entityList;
        }

        public IQueryable<Message> Build()
        {
            return EntityList;
        }
    }
}
