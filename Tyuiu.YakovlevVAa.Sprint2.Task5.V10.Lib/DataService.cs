
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakovlevVAa.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int PreviousDay = n;
            int PreviousMonth = m;
            int PreviousYear = m;
            int daysInMonth = 0;

            switch (m)
            {
                case 1:
                    daysInMonth = 31;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;
                case 3:
                    daysInMonth = 31;
                    break;
                case 4:
                    daysInMonth = 30;
                    break;
                case 5:
                    daysInMonth = 31;
                    break;
                case 6:
                    daysInMonth = 30;
                    break;
                case 7:
                    daysInMonth = 31;
                    break;
                case 8:
                    daysInMonth = 31;
                    break;
                case 9:
                    daysInMonth = 30;
                    break;
                case 10:
                    daysInMonth = 31;
                    break;
                case 11:
                    daysInMonth = 30;
                    break;
                case 12:
                    daysInMonth = 31;
                    break;
                default:
                    return ($"Некорректный номер месяца");





            }
            if ((n < daysInMonth) && (n > 1))
            {
                PreviousDay = n - 1;
            }
            if (n > daysInMonth)
            {
                return "День введён некорректно";
            }
            if (m < 2)
            {
                PreviousDay = daysInMonth;
                PreviousMonth = 12;
                PreviousYear = g - 1;
            }
            else
            {
                PreviousMonth = m - 1;
            }

            return PreviousDay + "." + PreviousMonth + "." + PreviousYear + " Год";
        }
    }
}    

