using SortBDay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBDay.Interface
{
    public interface IPersonManager
    {
        Task<(bool success, string message, PeopleSummary summary)> GetPeople();
        Task<(bool success, string message)> CreatePerson(PersonModel obj);
    }
}
