using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakovlevVAa.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool AboveLine = y >= x;
            bool BelowParabola = y <= 2 - (x * x);
            bool BelowLine = y <= x;
            if ((AboveLine && BelowParabola)||(BelowParabola&&BelowLine&&(y>0)))
                return true;
            else return false;
        }
    }
}
