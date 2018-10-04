using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiempo_y_Espacio
{
    class TimeAndSpace
    {
        protected bool LeapYear(int year)
        {

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return true;
            else
                return false;
            
        }

        protected float GetJulianYearDay(int day, int month, int year)
        {
            return (1461 * (year + 4800 + (month - 14) / 12)) / 4 + (367 - (month - 2 - 12 - ((month - 14) / 12))) / 12 - (3 * ((year + 4900 + (month - 14) / 12) / 100)) / 4 + day - 32075;
        }



        protected int RemainingYearDays(int day, int month, int year)
        {
            return (int)Math.Ceiling(GetJulianYearDay(31, 12, year) - GetJulianYearDay(day, month, year));
        }
    }
}
