using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask2.txt");
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            string stry = "";
            for (int i = 0; i<3;i++)
            {
                for (int j = 0;j< 3;j++)
                {
                    if (matrix[i, j]%2!=0)
                    {
                        matrix[i, j] = 0;
                    }
                    stry += matrix[i, j]+ ";" ;
                }
                int len = stry.Length - 1;
                stry = stry.Remove(len) + "\n";
            }
            Console.WriteLine(stry);
            File.WriteAllText(path, stry);
            return path;
        }
    }
}
