using Tyuiu.ArkhipovaMD.Sprint5.Task2.V7.Lib;
DataService ds  = new DataService();
int[,] matrix = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i,j]=Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine(ds.SaveToFileTextData(matrix));