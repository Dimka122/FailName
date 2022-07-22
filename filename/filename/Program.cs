//string directory = "D:\\Programs\\ Загрузки"; //Директория
//String[] dirs = Directory.GetFiles(directory, ".txt"); //Поиск всех файлов в папке с расширением txt

using Microsoft.Win32;
using System.Text;


//SOFTWARE\Microsoft\Windows\CurrentVersion\Run
//RegistryKey registry = Registry.CurrentUser;
//RegistryKey myAppKey = Registry.OpenSubKey(@"SOFTWARE\\Microsoft\Windows\CurrentVersion\Run", true);
//myAppKey.SetValue("MyApp", $"{Directory.GetCurrentDirectory()}//ConsoleApp3.exe");


//RegistryKey registry = Registry.LocalMachine;
//RegistryKey myAppKey = registry.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
//myAppKey.SetValue("filename", $"{Directory.GetCurrentDirectory()}//filename.exe");

string path = "/Users/eugene/Documents/content.txt";

string origanalText = "Привет Дима! Как дела?";

await File.WriteAllTextAsync(path, origanalText, Encoding.Unicode);
await File.AppendAllTextAsync(path, "\nПривет. Хорошо!", Encoding.Unicode);

string fileText = await File.ReadAllTextAsync(path, Encoding.Unicode);
Console.WriteLine(fileText);