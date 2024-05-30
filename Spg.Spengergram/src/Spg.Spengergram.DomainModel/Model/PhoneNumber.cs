namespace Spg.Spengergram.DomainModel.Model
{
    public enum PhoneNumberType { MOBILE }

    public record PhoneNumber(string Number, PhoneNumberType PhoneNumberType);
}
