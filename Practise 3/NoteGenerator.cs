using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practise_3.Program;

namespace Practise_3
{
    internal class NoteGenerator
    {
        // Метод для генерации заданного количества случайных заметок
        public static List<Note> GenerateNotes(int count)
        {
            List<Note> notes = new();
            Random random = new();

            // Списки для заголовков и содержимого заметок
            List<string> titles = new List<string>
        {
            "Какие книги нужно прочитать в январе",
            "Какие книги нужно прочитать в феврале",
            "Какие книги нужно прочитать в марте",
            "Какие книги нужно прочитать в апреле",
            "Какие книги нужно прочитать в мае",
        };

            List<string> contents = new List<string>
        {
            "'Преступление и наказание' Достоевского, 'Мастер и Маргарита' Булгакова",
            "'Гордость и предубеждение' Остин, 'Убить пересмешника' Харпер Ли",
            "'Анна Каренина' Толстого, 'Великий Гэтсби' Фицджеральда",
            "'451 градус по Фаренгейту' Брэдбери, 'Темные аллеи' Бунина",
            "'По ту сторону весов' Накамуры, 'Братья Карамазовы' Достоевского"
        };

            // Метод для получения случайной даты в пределах последних 6 месяцев
            DateTime GetRandomDate()
            {
                DateTime start = DateTime.Now.AddMonths(-6); // Начальная дата в 6 месяцев назад
                int range = (DateTime.Now - start).Days; // Подсчет диапазона дней
                return start.AddDays(random.Next(range)); // Возврат случайной даты в этом диапазоне
            }

            // Генерация заданного количества заметок
            for (int i = 0; i < count; i++)
            {
                ImportanceCategory category = (ImportanceCategory)random.Next(0, 3);
                string title = titles[random.Next(titles.Count)]; 
                string content = contents[random.Next(contents.Count)]; 
                DateTime createdDate = GetRandomDate();
                int id = notes.Count == 0 ? 1 : notes.Last().Id + 1; // Установить ID (или 1, если это первая заметка)

                Note note = new Note(category, title, content, createdDate, id); 
                notes.Add(note); 
            }

            return notes; 
        }
    }
}
