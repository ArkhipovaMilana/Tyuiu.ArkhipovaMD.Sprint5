using System.Runtime.Intrinsics.X86;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ArkhipovaMD.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int cnt = 0;
            string text=File.ReadAllText(path);
            string[] words=text.Split(' ');
            foreach(string word in words)
            {
                if (word.Length==8)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
