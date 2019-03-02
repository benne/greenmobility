using System;

namespace BenneIO.GreenMobility.Models
{
    public class DrivingLicence
    {
        public DrivingLicence(string number, string countryCode, string province, DateTime? expirationDate)
        {
            Number = number;
            CountryCode = countryCode;
            Province = province;
            ExpirationDate = expirationDate;
        }

        public string Number { get; }

        public string CountryCode { get; }

        public string Province { get; }

        public DateTime? ExpirationDate { get; }
    }
}