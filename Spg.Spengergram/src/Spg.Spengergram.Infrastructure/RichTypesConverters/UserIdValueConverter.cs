using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spg.Spengergram.DomainModel.Model;

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
