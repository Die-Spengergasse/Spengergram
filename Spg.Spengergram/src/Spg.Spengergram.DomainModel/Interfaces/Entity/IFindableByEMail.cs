using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.DomainModel.Interfaces.Entity
{
    public interface IFindableByEMail
    {
        public EMailAddress EMailAddress { get; }
    }
}
