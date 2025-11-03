using Tyuiu.ArkhipovaMD.Sprint5.Task5.V22.Lib;
DataService ds = new DataService();
string path =@"C:\DataSprint5\InPutDataFileTask5V22.txt";
Console.WriteLine(ds.LoadFromDataFile(path));