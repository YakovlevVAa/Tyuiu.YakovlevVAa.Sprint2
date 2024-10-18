using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakovlevVAa.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == b) | (b >= c);
            res[1] = (a > d) & (c < d);
            res[2] = (a >= c) || (c == d);
            res[3] = (d < a) && (d <= b);
            res[4] = !(b == a);
            res[5] = (b < a) ^ (a <= d);
            return res;
        }
    }
}
