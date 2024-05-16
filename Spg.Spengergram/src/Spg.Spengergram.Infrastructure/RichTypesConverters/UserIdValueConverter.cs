using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spg.Spengergram.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Infrastructure.RichTypesConverters
{
    public class UserIdValueConverter : ValueConverter<UserId, int>
    {
        public UserIdValueConverter(ConverterMappingHints mappingHints = null!)
            : base(
                id => id.Value,
                value => new UserId(value),
                mappingHints
            )
        { }
    }
}
