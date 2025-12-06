using Tyuiu.MolokanovNK.Sprint6.Task6.V20.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"С:\DataSprint6\InPutDataFileTask6V20.txt ";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
