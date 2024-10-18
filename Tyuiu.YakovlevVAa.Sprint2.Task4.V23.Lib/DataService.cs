using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakovlevVAa.Sprint2.Task4.V23.Lib
{
    public class DataService : ISprint2Task4V23

    {
        public double Calculate(double x, double y)
        {
            if (y >= 0)
            {
                double z = (x / 2) < Math.Sqrt(y) ? Math.Pow((1 + (1 / (y * y))), x) : y + 12 * x - (1 / x);
                return Math.Round(z, 3);
            }
            else
                return 0;
        }
    }
}
