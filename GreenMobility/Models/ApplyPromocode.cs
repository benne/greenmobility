namespace BenneIO.GreenMobility.Models
{
    public class ApplyPromocode
    {
        public ApplyPromocode(int? cityId, string promocode, bool isRegistration)
        {
            CityId = cityId;
            Promocode = promocode;
            IsRegistration = isRegistration;
        }

        public int? CityId { get; }

        public string Promocode { get; }

        public bool? IsRegistration { get; }
    }
}