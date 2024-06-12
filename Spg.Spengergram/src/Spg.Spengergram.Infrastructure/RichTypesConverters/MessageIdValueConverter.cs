using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spg.Spengergram.DomainModel.Model;

namespace Spg.Spengergram.Infrastructure.RichTypesConverters
{
    public class MessageIdValueConverter : ValueConverter<MessageId, int>
    {
        public MessageIdValueConverter(ConverterMappingHints mappingHints = null!)
            : base(
                id => id.Value,
                value => new MessageId(value),
                mappingHints
            )
        { }
    }
}
