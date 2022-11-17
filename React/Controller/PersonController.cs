using SortBDay.Interface;
using SortBDay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBDay.Controller
{
    public class PersonController
    {
        private IPersonManager _service;

        public PersonController(IPersonManager service)
        {
            this._service = service;
        }

        public async  Task<(bool success, string message)> CreatePerson(PersonModel obj)
        {
            try
            {
               var create =  _service.CreatePerson(obj).Result;

                if (create.success)
                    return await Task.FromResult((true, create.message));
                else
                    return (false, create.message);
               
            }
            catch (Exception ex)
            {
                return (false,ex.Message); 
            }
   
        }


        public async     Task<(bool success, string message, PeopleSummary summary)> GetPeople()
        {
            try
            {
                var getPeople = _service.GetPeople().Result;

                if (getPeople.success)
                    return await Task.FromResult((true, string.Empty, getPeople.summary));
                else
                    return (false, getPeople.message, null);

            }
            catch (Exception ex)
            {
                return (false,ex.Message, null);
            }

        }

    }
}
