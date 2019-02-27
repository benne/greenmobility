namespace BenneIO.GreenMobility.Models
{
    public class Location
    {
        public Location(Address address, Position position)
        {
            Address = address;
            Position = position;
        }

        public Address Address { get; }

        public Position Position { get; }
    }
}