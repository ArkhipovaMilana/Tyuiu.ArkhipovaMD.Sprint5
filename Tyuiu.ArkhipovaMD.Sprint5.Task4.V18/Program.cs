using Tyuiu.ArkhipovaMD.Sprint5.Task4.V18.Lib;

DataService ds  = new DataService();
string path = Path.Combine("C:","DataSprint5", "InPutDataFileTask4V18.txt");
Console.WriteLine(ds.LoadFromDataFile(path));