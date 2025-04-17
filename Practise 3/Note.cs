using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practise_3.Program;

namespace Practise_3
{
    internal class Note
    {
        // Свойство для хранения категории важности заметки
        public ImportanceCategory Category { get; set; }
        public DateTime CreatedDate { get; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Id { get; set; }

        // Конструктор для инициализации новой заметки
        public Note(ImportanceCategory category, string title, string content, DateTime createdDate, int id)
        {
            Category = category;
            Title = title; 
            Content = content; 
            CreatedDate = createdDate; 
            Id = id; 
        }

        // Метод для отображения информации о заметке на консоли
        public void DisplayInfo()
        {
            Console.ForegroundColor = GetCategoryColor(); // Установка цвета текста в зависимости от категории
            Console.WriteLine($"ID: {Id}"); 
            Console.WriteLine($"Заголовок: {Title}"); 
            Console.WriteLine($"Содержание: {Content}"); 
            Console.WriteLine($"Категория: {Category}"); 
            Console.WriteLine($"Дата создания: {CreatedDate:g}"); 
            Console.ResetColor(); 
            Console.WriteLine(new string('-', 40)); // Вывод разделителя
        }

        // Метод для получения цвета текста в зависимости от категории важности
        private ConsoleColor GetCategoryColor()
        {
            return Category switch
            {
                ImportanceCategory.High => ConsoleColor.Red, 
                ImportanceCategory.Medium => ConsoleColor.Yellow, 
                ImportanceCategory.Low => ConsoleColor.Green, 
                _ => ConsoleColor.White // Цвет по умолчанию - белый
            };
        }
    }
}
