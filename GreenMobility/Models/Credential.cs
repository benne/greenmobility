namespace BenneIO.GreenMobility.Models
{
    public class Credential
    {
        public Credential(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; }

        public string Password { get; }
    }
}