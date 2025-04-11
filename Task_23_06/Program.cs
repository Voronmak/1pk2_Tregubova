namespace Task_23_06
{
    internal class Program
    {
        /* Напишите программу со следующими функциями:
         * 1. Выведите информации о всех дисках в системе
         * 2. Выведите содержимое каталога C:\Users (названия папок)
         * 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
         * a) Создание вложенного каталога “temp”
         * b) Вывод информации о текущем каталоге (имя, родитель и тд)
         * c) Вывод информации о вложенном каталоге
         * 4. Переместите каталог “temp” по пути “D:\work\newTemp”
         * a) Реализуйте вывод информационного сообщения об успешном (или нет) 
         * перемещении
         * 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) 
         * удалении.
        */

        static void Main(string[] args)
        {
            {
                #pragma warning disable
                List<DriveInfo> drives = DriveInfo.GetDrives().ToList();
                Console.WriteLine("Диски в текущей системе");
                foreach (DriveInfo drive in drives)
                {

                    Console.WriteLine(
                        $"{drive.Name}:\n" +
                        $"  Размер диска: {drive.TotalSize / 1024 / 1024 / 1024} ГБ\n" +
                        $"  Доступное место: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} ГБ\n" +
                        $"  Тип диска: {drive.DriveType}\n" +
                        $"  Метка диска: {drive.VolumeLabel}\n");


                    string pathName = Console.ReadLine();
                    if (Directory.Exists(pathName))
                    {
                        Console.WriteLine($"файлы в папке {pathName}");
                        List<String> list = Directory.GetFiles(pathName).ToList();
                        if (list.Count > 0)
                        {
                            int n = 1;
                            foreach (String s in list)
                            {
                                Console.WriteLine(n + ":" + s);
                                n++;
                            }
                        }
                        else
                            Console.WriteLine("нет файлов");
                    }
                    else
                    {
                        Console.WriteLine("каталог не существует");
                    }
                    string work = @"D:\work";
                    string tempPath = Path.Combine(work, "temp");



                    Directory.CreateDirectory(work);


                    Directory.CreateDirectory(tempPath);
                    Console.WriteLine($"\nСоздана подпапка: {tempPath}");

                    Console.WriteLine("\n Информация о текущем каталоге:");
                    DirectoryInfo workDir = new DirectoryInfo(work);
                    Console.WriteLine($"  Имя: {workDir.Name}");
                    Console.WriteLine($"  Полный путь: {workDir.FullName}");
                    Console.WriteLine($"  Родительский каталог: {workDir.Parent}");
                    Console.WriteLine($"  Время создания: {workDir.CreationTime}");
                    Console.WriteLine($"  Атрибуты: {workDir.Attributes}");

                    Console.WriteLine("\nИнформация о вложенном каталоге temp:");
                    DirectoryInfo tempDir = new DirectoryInfo(tempPath);
                    Console.WriteLine($"  Имя: {tempDir.Name}");
                    Console.WriteLine($"  Полный путь: {tempDir.FullName}");
                    Console.WriteLine($"  Родительский каталог: {tempDir.Parent.Name}");
                    Console.WriteLine($"  Время создания: {tempDir.CreationTime}");


                    string newTempPath = @"D:\work\newTemp";
                    if (Directory.Exists(tempPath))
                    {
                        if (!Directory.Exists(newTempPath))
                        {
                            Directory.Move(tempPath, newTempPath);
                            Console.WriteLine($"\nПапка перемещена в: {newTempPath}");
                        }
                        else
                        {
                            Console.WriteLine($"\nТакая папка уже существует: {newTempPath}");
                        }
                    }
                    if (Directory.Exists(tempPath))
                    {
                        Directory.Delete(tempPath);
                        Console.WriteLine($"\nКаталог {tempPath} успешно удален");
                    }
                    else
                    {
                        Console.WriteLine($"\nКаталог {tempPath} не существует (уже перемещен)");
                    }
                }
            }
        }
    }
}
