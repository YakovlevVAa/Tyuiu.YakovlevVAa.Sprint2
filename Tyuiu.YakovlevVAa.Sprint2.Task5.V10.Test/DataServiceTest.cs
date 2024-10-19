using Tyuiu.YakovlevVAa.Sprint2.Task5.V10.Lib;
namespace Tyuiu.YakovlevVAa.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 1;
            int n = 1;
            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(g, m, n));
            
        }
    }
}