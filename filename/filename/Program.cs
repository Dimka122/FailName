using Microsoft.Win32;
using System.Text;

DirectoryInfo dir = new DirectoryInfo(@"C:/Code/FileName/fileName");
if (Directory.Exists(@"C:/Code/FileName/fileName"))
{    
Console.WriteLine("список каталогов");
}
foreach(var item in dir.GetDirectories())
{
    //Console.ReadLine();
    Console.WriteLine(dir.Name+item.Name + Environment.NewLine);
}



string path = "C:/Code/FileName/fileName/content.txt";

string origanalText = "Привет Дима! Как дела?";

await File.WriteAllTextAsync(path, origanalText, Encoding.Unicode);
await File.AppendAllTextAsync(path, "\nПривет. Хорошо!", Encoding.Unicode);


string fileText = await File.ReadAllTextAsync(path, Encoding.Unicode);

Console.WriteLine(fileText);


//RegistryKey registry = Registry.LocalMachine;
//RegistryKey myAppKey = registry.OpenSubKey(@"SOFTWARE/Microsoft/Windows/CurrentVersion/Run", true);
//myAppKey.SetValue("filename", $"{Directory.GetCurrentDirectory()}//filename.exe");

