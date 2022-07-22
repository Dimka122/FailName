//string directory = "D:\\Programs\\ Загрузки"; //Директория
//String[] dirs = Directory.GetFiles(directory, ".txt"); //Поиск всех файлов в папке с расширением txt

using Microsoft.Win32;
using System.IO;


//SOFTWARE\Microsoft\Windows\CurrentVersion\Run
//RegistryKey registry = Registry.CurrentUser;
//RegistryKey myAppKey = Registry.OpenSubKey(@"SOFTWARE\\Microsoft\Windows\CurrentVersion\Run", true);
//myAppKey.SetValue("MyApp", $"{Directory.GetCurrentDirectory()}//ConsoleApp3.exe");

//SOFTWARE\Microsoft\Windows\CurrentVersion\Run
RegistryKey registry = Registry.LocalMachine;
RegistryKey myAppKey = registry.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
myAppKey.SetValue("filename", $"{Directory.GetCurrentDirectory()}//filename.exe");

string dirName = "C:\\Users\\Дима\\Изображения";
var directory = Directory.GetFiles(dirName, ".txt");

if (directory.Exists)
{
    Console.WriteLine("Подкаталоги");
    DirectoryInfo[] dirs = directory.GetDirectories();
}
foreach (DirectoryInfo dir in dirs)
{
    Console.WriteLine(dir.FullName);
}

    Console.WriteLine();
Console.WriteLine("Файлы");
FileInfo[] files = directory.GetFiles();
foreach(FileInfo file in files)
{
    Console.WriteLine(files.Fullname);
}





