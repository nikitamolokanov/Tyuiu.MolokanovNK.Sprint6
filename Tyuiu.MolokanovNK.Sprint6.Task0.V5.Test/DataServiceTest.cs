using Tyuiu.MolokanovNK.Sprint6.Task0.V5.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(5);
            double wait = -114.5;
            Assert.AreEqual(res, wait);
        }
    }
}
