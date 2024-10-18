using Tyuiu.YakovlevVAa.Sprint2.Task0.V23.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task0.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 795;
            bool[] res = new bool[2];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #1 | Выполнил: Яковлев В. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Яковлев Виктор Александрович | ИИПб-24-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую                   *");
            Console.WriteLine("* последовательность(массив): (True, False, True, True, False, True),     *");
            Console.WriteLine("*  при x = 105, y = 795                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X =" + x);
            Console.WriteLine("Y =" + y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}
