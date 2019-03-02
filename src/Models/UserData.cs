using System;
using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class UserData
    {
        public UserData(int? accountType, Address address, Address billingAddress, DateTime? birthDate,
            DrivingLicence drivingLicence, string email, bool emailConsent, IEnumerable<UserKeyValue> extendedInfo,
            string firstName, string gender, string identificationNumber, int? identificationType, string lastName,
            string locale, string middleName, string phoneNumber, string preferredUsername)
        {
            AccountType = accountType;
            Address = address;
            BillingAddress = billingAddress;
            BirthDate = birthDate;
            DrivingLicence = drivingLicence;
            Email = email;
            EmailConsent = emailConsent;
            ExtendedInfo = extendedInfo;
            FirstName = firstName;
            Gender = gender;
            IdentificationNumber = identificationNumber;
            IdentificationType = identificationType;
            LastName = lastName;
            Locale = locale;
            MiddleName = middleName;
            PhoneNumber = phoneNumber;
            PreferredUsername = preferredUsername;
        }

        public int? AccountType { get; }

        public Address Address { get; }

        public Address BillingAddress { get; }

        public DateTime? BirthDate { get; }

        public DrivingLicence DrivingLicence { get; }

        public string Email { get; }

        public bool EmailConsent { get; }

        public IEnumerable<UserKeyValue> ExtendedInfo { get; }

        public string FirstName { get; }

        public string Gender { get; }

        public string IdentificationNumber { get; }

        public int? IdentificationType { get; }

        public string LastName { get; }

        public string Locale { get; }

        public string MiddleName { get; }

        public string PhoneNumber { get; }

        public string PreferredUsername { get; }
    }
}