using Tyuiu.ArkhipovaMD.Sprint5.Task4.V18.Lib;

DataService ds  = new DataService();



Console.Title = "Спринт #5 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #18                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V18.txt");

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");
Console.WriteLine(ds.LoadFromDataFile(path));