using SortBDay.Helper;
using SortBDay.Interface;
using SortBDay.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortBDay.DAL
{
    public class Person : IPersonManager
    {
 
        public Person()
        {
          
        }

        private (bool success, string message) PersonValidation(PersonModel obj)
        {
            StringBuilder sb = new StringBuilder();


            if (string.IsNullOrWhiteSpace(obj.Name))
                sb.AppendLine("Please provide Person Name");

            if (string.IsNullOrWhiteSpace(obj.Surname))
                sb.AppendLine("Please provide Person Surname");

            if (string.IsNullOrWhiteSpace(obj.DateofBirth.ToString()))
                sb.AppendLine("Please provide Person Surname");

            if (obj.DateofBirth.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                sb.AppendLine("Date of Birth cannot be today");

            if (string.IsNullOrEmpty(sb.ToString()))
                return (true, null);
            else
                return (false, sb.ToString());

        }

        public async Task<(bool success, string message)> CreatePerson(PersonModel obj)
        {
            try
            {
                if (string.IsNullOrEmpty(FileHelper.FileName))
                    return (false, "Could not save new Person, file store has not been set");

                var validatePerson = PersonValidation(obj);
                if (validatePerson.success)
                {

                    var lines = FileHelper.ReadFromFile();

                    var personString = $"{lines.Count()}, {obj.Name}, {obj.Surname}, { obj.DateofBirth}";

                    FileHelper.WriteToFile(personString);

                    return await Task.FromResult((true, "New Person has been created"));
                }
                else

                    return (false, validatePerson.message);

            }
            catch (Exception ex)
            {

                return (false, ex.Message);
            }
        }

        public async Task<(bool success, string message, PeopleSummary summary)> GetPeople()
        {

            List<PersonModel> array = new List<PersonModel>();

            try
            {
                var lines  = FileHelper.ReadFromFile();

                var count = 0;
                var sumAge = 0;

                foreach (var row in lines)
                {
                    var lineSplit = row.Split(',');

                    var age = DateTime.Now.Year - Convert.ToDateTime(lineSplit[3]).Year;

                    sumAge = sumAge + age;

                    array.Add(new PersonModel()
                    {
                        Id = Convert.ToInt32(lineSplit[0]),
                        DateofBirth = Convert.ToDateTime(lineSplit[3]),
                        Name = (lineSplit[1]),
                        Surname = (lineSplit[2]),
                        Age = age,
                        PersonDateDescription = $"{Convert.ToDateTime(lineSplit[3]).ToString("dd MMM yyyy")}, I'm {age} years old"
                    });

                    count++;
                }

                array = (from a in array
                        orderby a.Name
                        select a).ToList();


                return await Task.FromResult((true, string.Empty, new PeopleSummary()
                {
                    People = array,
                    AgeAverage = sumAge / count
                })); 
            }
            catch (Exception ex)
            {
                return (false, ex.Message,null);
            }
        }
    }
}
