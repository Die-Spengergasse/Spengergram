using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Dtos
{
    public record UserDto
    (
        Guid Id,
        string FirstName,
        string LastName
    );
}
