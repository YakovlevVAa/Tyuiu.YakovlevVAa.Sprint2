using Tyuiu.YakovlevVAa.Sprint2.Task6.V11.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 12;
            int n = 31;
            Assert.AreEqual("01.01.2024", ds.FindDateOfNextDay(g, m, n));
        }
    }
}