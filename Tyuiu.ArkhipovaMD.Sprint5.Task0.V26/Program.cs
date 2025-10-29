using Tyuiu.ArkhipovaMD.Sprint5.Task0.V26.Lib;

int x = 5;
DataService ds  = new DataService();
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл "+ res + " Создан!");