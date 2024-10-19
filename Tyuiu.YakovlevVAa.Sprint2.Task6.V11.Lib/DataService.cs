using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakovlevVAa.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int nextDay = n;
            int nextMonth = m;
            int nextYear = g;
            int daysInMonth = 0;
            switch (m)
            {
                case 1: daysInMonth = 31; break;                  
                case 2: daysInMonth = 28; break;                    
                case 3: daysInMonth = 31; break;                    
                case 4: daysInMonth = 30; break;
                case 5: daysInMonth = 31; break;
                case 6: daysInMonth = 30; break;
                case 7: daysInMonth = 31; break;
                case 8: daysInMonth = 31; break;
                case 9: daysInMonth = 30; break;
                case 10: daysInMonth = 31; break;
                case 11: daysInMonth = 30; break;
                case 12: daysInMonth = 31; break;
                default: return ($"Некорректный номер месяца");


            }

        
            if ((n<daysInMonth) && (n > 1))
            {
                nextDay = n + 1;
                nextYear = g; 
                nextMonth = m;
            }
            if (n > daysInMonth)
            {
                return "День введён некорректно";
            }
            if (m > 11)
            {
                nextDay = 1;
                nextMonth = 1;
                nextYear = g + 1;
            }
            else
            {
                nextDay = n + 1;
                nextYear = g;
                nextMonth = m;
            }

            if (((nextDay > 0) && (nextDay < 10)) && ((nextMonth > 0) && (nextMonth < 10)))
            {
                return "0" + nextDay + "." + "0" + nextMonth + "." + nextYear;
            }
            if ((nextDay > 0) && (nextDay < 10))
            {
                return "0" + nextDay + "." + nextMonth + "." + nextYear;
            }
            if ((nextMonth > 0) && (nextMonth < 10))
            {
                return "0" + nextDay + "." + nextMonth + "." + nextYear;
            }
            return nextDay + "." + nextMonth + "." + nextYear;

        }
    }
}
