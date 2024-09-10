using Spg.Spengergram.DomainModel.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Commands
{
    public record CreateMessageCommand(
        Guid Messanger,
        [StringLength(255, ErrorMessage = "Message between 1 and 255 chars", MinimumLength = 1)]
        string Body,
        UserDto CreatedBy
    );
}
