using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateOnly dob)
        {
            // var today = DateOnly.FromDateTime(DateTime.Now);

            // var age = today.Year - dob.Year;

            // if (dob > today.AddYears(-age)) age--;

            // return age;

                DateOnly today = DateOnly.FromDateTime(DateTime.Now);  // Get the current date
                int age = today.Year - dob.Year;

                // Adjust the age if the birthday hasn't occurred yet this year
                if (today < dob.AddYears(age))
                {
                    age--;
                }

                return age;

            
        }
    }
}