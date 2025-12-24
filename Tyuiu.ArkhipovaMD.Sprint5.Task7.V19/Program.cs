using Tyuiu.ArkhipovaMD.Sprint5.Task7.V19.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #19                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
Console.WriteLine(ds.LoadDataAndSave(@"C:\DataSprint5\InPutDataFileTask7V19.txt"));