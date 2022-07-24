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

string ShortCutPath = Environment.CurrentDirectory + @"C:\Code\FileName\fileName\filename.exe"; // полный путь, где будет создан ярлык

Microsoft.Win32.RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
Key.SetValue("filename", ShortCutPath);



//удаляем  

//Microsoft.Win32.RegistryKey key =
//Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
//    "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);

//key.DeleteValue("filename", false);
//key.Close();
