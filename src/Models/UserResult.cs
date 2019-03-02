using System;
using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class UserResult : UserData
    {
        public UserResult(int? accountType, Address address, Address billingAddress, DateTime? birthDate,
            DrivingLicence drivingLicence, string email, bool emailConsent, IEnumerable<UserKeyValue> extendedInfo,
            string firstName, string gender, string identificationNumber, int? identificationType, string lastName,
            string locale, string middleName, string phoneNumber, string preferredUsername, IEnumerable<Agreement> agreements,
            string id, int? cityId)
            : base(accountType, address, billingAddress, birthDate, drivingLicence, email, emailConsent, extendedInfo,
                  firstName, gender, identificationNumber, identificationType, lastName, locale, middleName, phoneNumber,
                  preferredUsername)
        {
            Agreements = agreements;
            Id = id;
            CityId = cityId;
        }

        public IEnumerable<Agreement> Agreements { get; }

        public string Id { get; }

        public int? CityId { get; }
    }
}