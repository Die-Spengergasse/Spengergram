using Spg.Spengergram.DomainModel.Interfaces.Entity;

namespace Spg.Spengergram.DomainModel.Model
{
    public record UserId(int Value) : IRichType<int>
    { }

    public record MessageId(int Value) : IRichType<int>
    { }

    public record MessengerId(int Value) : IRichType<int>
    { }

    public record CommentId(int Value) : IRichType<int>
    { }
}
