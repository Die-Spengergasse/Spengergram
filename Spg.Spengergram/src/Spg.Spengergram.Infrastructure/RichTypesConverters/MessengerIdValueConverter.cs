using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spg.Spengergram.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.Infrastructure.RichTypesConverters
{
    public class MessengerIdValueConverter : ValueConverter<MessengerId, int>
    {
        public MessengerIdValueConverter(ConverterMappingHints mappingHints = null!)
            : base(
                id => id.Value,
                value => new MessengerId(value),
                mappingHints
            )
        { }
    }
}
