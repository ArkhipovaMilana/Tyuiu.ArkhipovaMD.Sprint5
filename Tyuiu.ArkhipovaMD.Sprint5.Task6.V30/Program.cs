using Tyuiu.ArkhipovaMD.Sprint5.Task6.V30.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #30                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

string path = @"C:\DataSprint5\InPutDataFileTask6V30.txt";
Console.WriteLine(ds.LoadFromDataFile(path));