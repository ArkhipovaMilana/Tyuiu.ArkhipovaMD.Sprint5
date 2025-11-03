using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string text =File.ReadAllText(path);
            text.Replace("cc", "");
            return text;
        }
    }
}
