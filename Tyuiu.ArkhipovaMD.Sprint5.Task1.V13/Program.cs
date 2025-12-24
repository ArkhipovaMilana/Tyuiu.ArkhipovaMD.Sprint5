using Tyuiu.ArkhipovaMD.Sprint5.Task1.V13.Lib;

DataService ds  = new DataService();
Console.Title = "Спринт #5 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #13                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

string result = Path.GetTempPath();
Console.WriteLine(result);
Console.WriteLine(ds.SaveToFileTextData(-5,5));