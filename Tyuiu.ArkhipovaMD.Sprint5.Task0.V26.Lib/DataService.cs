using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string dir = Path.Combine(Environment.CurrentDirectory, "app");
            Directory.CreateDirectory(dir);
            string path = Path.Combine(dir, "OutputFileTask0.txt");
            double fx = Math.Round(0.7*Math.Pow(x, 3)+1.52*Math.Pow(x,2),3);
            File.WriteAllText(path,Convert.ToString(fx));
            return path;
        }
    }
}
