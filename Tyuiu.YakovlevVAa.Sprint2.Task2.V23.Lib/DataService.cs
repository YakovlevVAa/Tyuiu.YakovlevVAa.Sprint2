using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YakovlevVAa.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3)&&(x <= 5)&&(y <= 5)&&(y>=3))|((x == 6) && (y == 5))|((x >= 7) && (x <= 12) && (y >= 5) && (y <= 11))|((x >= 9) && (x <= 12) && (y >= 3) && (y <= 4))|((x >= 3) && (x <= 6) && (x == 13) && (y == 11))|((x >= 7) && (x <= 10) && (x >= 12) && (x <= 13) && (y == 12))|((x == 6) && (y <= 10) && (y >= 9))|((x == 13) && (y <= 8) && (y >= 6))|((x==3)&&(y==11)))
                res = true;
            else
                res = false;
            return res;

        }
    }
}
