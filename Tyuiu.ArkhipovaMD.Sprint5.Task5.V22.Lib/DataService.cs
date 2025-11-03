using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] strings = text.Split(" ");
            List<double> Numbers = new List<double>();
            foreach (string s in strings)
            {
                if (double.TryParse(s, out double d) && d % 4 == 0 && Convert.ToInt32(d) == d)
                {
                    Numbers.Add(d);
                }

            }
            Numbers.Sort();
            return Numbers[0];
        }
    }
}
