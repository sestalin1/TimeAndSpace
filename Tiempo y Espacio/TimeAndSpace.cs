using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tiempo_y_Espacio
{
    class TimeAndSpace
    {

        int[] monthDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        public void Manager()
        {
            int day;
            int month;
            int year;
            string date = "";
            Match validation;
            Regex regex = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
            
            Console.WriteLine("Ingrese la fecha válida en el formato: DD/MM/YYYY");
            date = Console.ReadLine();
            validation = regex.Match(date);
            try
            {
                if (validation.Success)
                {
                    day = int.Parse(date.Substring(0, 2));
                    month = int.Parse(date.Substring(3, 2));
                    year = int.Parse(date.Substring(6, 4));


                    if (IsLeapYear(year))
                    {
                        monthDays[1] = 29;
                        Console.WriteLine("Año Bisiesto");
                    }
                        
                    else
                        Console.WriteLine("Año No Bisiesto");
                    
                    Console.WriteLine("Día del año: " + GetDayOfYear(day, month, year).ToString());
                    Console.WriteLine("Días restantes del año: " + RemainingYearDays(day, month, year).ToString());
                    Console.WriteLine("Día siguiente: " + GetNextDay(day, month, year).ToString());


                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
            }
            finally
            {
                monthDays[1] = 28;
                Manager();
            }

        }

        public bool IsLeapYear(int year)
        {

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return true;
            else
                return false;

        }

        public int GetDayOfYear(int day, int month, int year)
        {
            int count = 0;
            int dayOfyear = 0;


            for (int i = 0; i < month - 1; i++)
                count += monthDays[i];

            dayOfyear = (count + day);

            return dayOfyear;
        }

        public string GetNextDay(int day, int month, int year)
        {
            if (day<monthDays[month-1])
            {
                day++;
            }
            else if (day == monthDays[month - 1])
            {
                if (day == monthDays[month - 1] && month == 12)
                {
                    day=1;
                    month=1;
                    year++;
                }
                else if(day == monthDays[month - 1] && month != 12)
                {
                    day=1;
                    month++;
                }

                
            }

            return day+"/"+month+"/"+year;
        }
        
        public int RemainingYearDays(int day, int month, int year)
        {
            return GetDayOfYear(31, 12, year) - GetDayOfYear(day, month, year);
        }


    }
}
