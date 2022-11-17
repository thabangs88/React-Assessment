using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBDay.Model
{
    public class PeopleSummary
    {
        public PeopleSummary()
        {
            People = new List<PersonModel>();
        }

        public List<PersonModel> People { get; set; }
        public int AgeAverage { get; set; }
    }
}
