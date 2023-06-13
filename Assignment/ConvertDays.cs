using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ConvertDays
    {
        public static void convertDays()
        {
            int ndays, weeks, years,days, DaysInWeek = 7;

            Console.WriteLine("please enter the number of days:");
            ndays = Convert.ToInt32(Console.ReadLine()); 

            years = ndays / 365;
            weeks = (ndays % 365)/ DaysInWeek;
            days = (ndays % 365) % DaysInWeek;
            

            Console.WriteLine("{0} days equal to {1} years, {2} weeks, and {3} days.", ndays, years,weeks,days);
    

            Console.ReadLine();
        
        }
    }
}
