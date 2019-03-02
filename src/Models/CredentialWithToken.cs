using System;

namespace BenneIO.GreenMobility.Models
{
    public class CredentialWithToken : Credential
    {
        public CredentialWithToken(string login, string password, Guid? token)
            : base(login, password)
        {
            Token = token;
        }

        public Guid? Token { get; }
    }
}