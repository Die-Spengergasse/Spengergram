using System.ComponentModel.DataAnnotations;

namespace Spg.Spengergram.DomainModel.Commands
{
    public record UpdateProfileCommand(
        Guid Id,
        [StringLength(maximumLength: 20, ErrorMessage = "Length must be between 2 and 20", MinimumLength = 2)]
        string FirstName,
        [StringLength(maximumLength: 20, ErrorMessage = "Length must be between 2 and 20", MinimumLength = 2)]
        string LastName);
}
