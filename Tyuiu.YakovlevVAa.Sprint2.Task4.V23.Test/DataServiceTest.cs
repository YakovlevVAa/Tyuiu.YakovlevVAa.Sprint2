using Tyuiu.YakovlevVAa.Sprint2.Task4.V23.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1.129;
            Assert.AreEqual(wait, res);
            
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 51.75;
            Assert.AreEqual(wait, res);

        }
    }
}