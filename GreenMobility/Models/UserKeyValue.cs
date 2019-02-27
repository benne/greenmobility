namespace BenneIO.GreenMobility.Models
{
    public class UserKeyValue
    {
        public UserKeyValue(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }

        public string Value { get; }
    }
}