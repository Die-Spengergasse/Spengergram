using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Spengergram.DomainModel.Model
{
    public enum PhoneNumberType { MOBILE }

    public record PhoneNumber(string Number, PhoneNumberType PhoneNumberType);
}
