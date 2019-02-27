namespace BenneIO.GreenMobility.Models
{
    public class UserProfile
    {
        public UserProfile(string role, string status)
        {
            Role = role;
            Status = status;
        }

        public string Role { get; }

        public string Status { get; }
    }
}