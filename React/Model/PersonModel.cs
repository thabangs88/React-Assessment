using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBDay.Model
{
    public class PersonModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string PersonDateDescription { get; set; }
    }

  
}
