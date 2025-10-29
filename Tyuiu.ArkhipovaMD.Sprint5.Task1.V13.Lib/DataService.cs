using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask1.txt");
            int len = stopValue - startValue + 1;
            double y;
            string stry="i";
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) == -x)
                {
                    y = 0;
                    Convert.ToString(y);
                }
                else
                {
                    y = Math.Round(2*x-3/ (Math.Cos(x) + x), 2);
                    stry = Convert.ToString(y);
                }
                File.WriteAllText(path,$"{stry}\t");
            }
            return path;
        }
    }
}
