using System.Net;
using Tyuiu.ArkhipovaMD.Sprint5.Task3.V10.Lib;

DataService ds  = new DataService();


Console.Title = "Спринт #5 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #10                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
int x = 4;

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл " + res + " Создан!");
string result = Path.GetTempPath();
Console.WriteLine(result);