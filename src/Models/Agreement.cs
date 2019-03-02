using System;

namespace BenneIO.GreenMobility
{
    public class Agreement
    {
        public Agreement(int? cityId, DateTime? date)
        {
            CityId = cityId;
            Date = date;
        }

        public int? CityId { get; }

        public DateTime? Date { get; }
    }
}