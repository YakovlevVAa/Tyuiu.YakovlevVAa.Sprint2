using Tyuiu.YakovlevVAa.Sprint2.Task0.V23.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 16;
            int y = 18;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, true, false, true };
            CollectionAssert.AreEqual(wait,res);
        }
    }
}