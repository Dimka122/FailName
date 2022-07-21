//string directory = "D:\\Programs\\ Загрузки"; //Директория
//String[] dirs = Directory.GetFiles(directory, ".txt"); //Поиск всех файлов в папке с расширением txt

using Microsoft.Win32;


//SOFTWARE\Microsoft\Windows\CurrentVersion\Run
//RegistryKey registry = Registry.CurrentUser;
//RegistryKey myAppKey = Registry.OpenSubKey(@"SOFTWARE\\Microsoft\Windows\CurrentVersion\Run", true);
//myAppKey.SetValue("MyApp", $"{Directory.GetCurrentDirectory()}//ConsoleApp3.exe");

//SOFTWARE\Microsoft\Windows\CurrentVersion\Run
RegistryKey registry = Registry.LocalMachine;
RegistryKey myAppKey = registry.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
myAppKey.SetValue("MyApp", $"{Directory.GetCurrentDirectory()}//DIMKA.exe");

