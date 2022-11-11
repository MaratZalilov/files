using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace files;

public class WorkWithFile
{
    public string File1 = @"C:\Users\студент2\Desktop\одын\MyFile.txt";
    public string File2 = @"C:\Users\студент2\Desktop\дывыа\MyFile.txt";
    public string _enter;
    public void CreateFile()
    {
        string enter = Console.ReadLine();
        Console.WriteLine("Введите название файла");
        string path =  $@"C:\Users\студент2\Desktop\одын\{enter}.txt";
        _enter = enter;
        FileInfo FileInf = new FileInfo(path);
        if (!FileInf.Exists)
        {
            FileInf.Create();

        }
    }

    public void MoveFile()
    {
        FileInfo FileInf = new FileInfo(File1);
        if (FileInf.Exists)
        {
            FileInf.MoveTo(File2);
        }
    }
    public void WriteByStringInFile()
    {
        string path =  $@"C:\Users\студент2\Desktop\одын\{_enter}.txt";
        Console.WriteLine("Что записать?");
        string text = Console.ReadLine();
        FileInfo FileInfo = new FileInfo(path);
        using(FileStream FileOut = new FileStream(path, FileMode.OpenOrCreate))
        {
            byte[] buffer = Encoding.Default.GetBytes(text);
             FileOut.Write(buffer, 0, buffer.Length);
            Console.WriteLine("Текст записан в файл");
        }
    }
    public void DeleteFile()
    {
        string path = $@"C:\Users\студент2\Desktop\одын\{_enter}.txt";
        FileInfo FileInf = new FileInfo(File1);
        if (FileInf.Exists)
        {
            FileInf.Delete();
            
        }
    }
}