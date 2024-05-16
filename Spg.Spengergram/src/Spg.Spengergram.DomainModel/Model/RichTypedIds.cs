using Spg.Spengergram.DomainModel.Interfaces.Entity;

namespace Spg.Spengergram.DomainModel.Model
{
    public record UserId(int Value) : IRichType<int>
    { }
}
