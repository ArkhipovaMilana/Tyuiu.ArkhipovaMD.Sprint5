using Tyuiu.ArkhipovaMD.Sprint5.Task2.V7.Lib;
DataService ds  = new DataService();




Console.Title = "Спринт #5 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
int[,] matrix = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");
Console.WriteLine(ds.SaveToFileTextData(matrix));
string res = ds.SaveToFileTextData(matrix);
Console.WriteLine("Файл " + res + " Создан!");
string result = Path.GetTempPath();
Console.WriteLine(result);