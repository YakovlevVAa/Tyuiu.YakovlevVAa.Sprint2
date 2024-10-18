using Tyuiu.YakovlevVAa.Sprint2.Task2.V23.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}