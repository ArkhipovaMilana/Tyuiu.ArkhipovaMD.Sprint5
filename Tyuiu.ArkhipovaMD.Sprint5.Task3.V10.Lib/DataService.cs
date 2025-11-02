using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            double fx = Math.Round(-Math.Pow(x, 3) + 4 * x * x - (3 / 2) * x,3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate),Encoding.UTF8))
            {
                writer.Write(fx);
            }
            Console.WriteLine(fx);
            return path;
        }
    }
}
