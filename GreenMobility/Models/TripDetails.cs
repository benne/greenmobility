using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class TripDetails
    {
        public TripDetails(IEnumerable<string> options)
        {
            Options = options;
        }

        public IEnumerable<string> Options { get; }
    }
}