using files;

WorkWithFile file = new WorkWithFile();
void Menu()
{
    Console.WriteLine("Выберете пункт");
    Console.WriteLine();
    Console.WriteLine("1.Создать файл");
    Console.WriteLine("2.Переместить файл");
    Console.WriteLine("3.Создать текст");
    Console.WriteLine("4.Удалить файл");

}
void FuncMenu()
{
    Menu();
    string Enter = Console.ReadLine();
    bool parse = int.TryParse(Enter, out int exit);
    if (parse)
    {
        switch (exit)
        {
            case 1:
                file.CreateFile();
                Console.WriteLine("Вы создали файл");                
                break;
            case 2:
                file.MoveFile();
                Console.WriteLine("Вы переместили файл");
                break;
            case 3:               
                file.WriteByStringInFile();

                break;
            case 4:
                file.DeleteFile();
                break;
            default:
                Console.WriteLine("Введите пункт из меню");
                break;
        }
    }
    else
    {
        Console.WriteLine("Для выбора пункта используйте цифры");
    }
}
while (true)
{
    FuncMenu();
}