using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            double x = 0;
            string data =File.ReadAllText(path);
            x = Convert.ToDouble(data.Replace(".",","));
            double y =Math.Round(Math.Cos(x)+(x*x/2),3);
            return y;
        }
    }
}
