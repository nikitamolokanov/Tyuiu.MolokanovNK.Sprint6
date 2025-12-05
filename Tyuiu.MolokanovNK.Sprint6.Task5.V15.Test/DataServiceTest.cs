using Tyuiu.MolokanovNK.Sprint6.Task5.V15.Lib;

namespace Tyuiu.MolokanovNK.Sprint6.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"С:\DataSprint6\InPutDataFileTask5V15.txt ";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
