using System.Collections.Generic;

namespace BenneIO.GreenMobility.Models
{
    public class ReportDetails
    {
        public ReportDetails(IEnumerable<long> categories)
        {
            Categories = categories;
        }

        public IEnumerable<long> Categories { get; }
    }
}