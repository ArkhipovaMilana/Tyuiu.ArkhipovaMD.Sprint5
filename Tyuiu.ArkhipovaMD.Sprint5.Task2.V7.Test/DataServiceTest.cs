
namespace Tyuiu.ArkhipovaMD.Sprint5.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\arkhi\source\repos\Tyuiu.ArkhipovaMD.Sprint5\Tyuiu.ArkhipovaMD.Sprint5.Task0.V26\bin\Debug\net8.0\OutputFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
