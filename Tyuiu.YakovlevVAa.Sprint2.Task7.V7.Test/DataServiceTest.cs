using Tyuiu.YakovlevVAa.Sprint2.Task7.V7.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.1;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}