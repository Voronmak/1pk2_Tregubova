using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Practise_3.Program;

namespace Practise_3
{
    internal class Notebook
    {
        private static List<Note> notes = new List<Note>(); // Список для хранения заметок
        private static string dataFile = "notes.json"; // Путь к файлу для хранения данных
        private static int nextId = 1; // Счетчик для следующего ID заметки

        // Метод инициализации для загрузки заметок из файла или их генерации
        public static void Initialize()
        {
            if (File.Exists(dataFile)) // Проверка существования файла данных
            {
                string json = File.ReadAllText(dataFile); 
                notes = JsonSerializer.Deserialize<List<Note>>(json); // Десериализация JSON в список заметок
                nextId = notes.Count > 0 ? notes.Max(n => n.Id) + 1 : 1; // Установка следующего ID
            }

            else 
            {
                notes = NoteGenerator.GenerateNotes(5); // Генерация начальных заметок
                nextId = notes.Count > 0 ? notes.Max(n => n.Id) + 1 : 1; // Установка следующего ID
                SaveNotes(); 
            }
        }

        // Метод для сохранения заметок в JSON файл
        private static void SaveNotes()
        {
            string json = JsonSerializer.Serialize(notes, new JsonSerializerOptions { WriteIndented = true }); // Сериализация списка в JSON
            File.WriteAllText(dataFile, json); // Запись JSON в файл
        }

        // Метод для добавления новой заметки в блокнот
        public static void AddNote(Note note)
        {
            note.Id = nextId++; // Назначение ID заметке и увеличение счетчика
            notes.Add(note); // Добавление заметки в список
            SaveNotes(); // Сохранение изменений в файл
        }

        // Метод для изменения категории существующей заметки
        public static bool ChangeNoteCategory(int noteId, ImportanceCategory newCategory)
        {
            Note note = notes.FirstOrDefault(n => n.Id == noteId); // Поиск заметки по ID
            if (note != null) // Если заметка найдена
            {
                note.Category = newCategory; 
                SaveNotes(); 
                return true; 
            }

            return false; 
        }

        // Метод для получения заметок, отсортированных по дате создания
        public static List<Note> GetNotesByCreationDate()
        {
            return notes.OrderBy(n => n.CreatedDate).ToList(); // Возвращаем отсортированный список заметок
        }

        // Метод для получения заметок по категориям
        public static List<Note> GetNotesByCategory(ImportanceCategory category)
        {
            return notes.Where(n => n.Category == category).ToList(); // Возвращаем фильтрацию по категории
        }

        public static void DisplayAllNotes()
        {
            foreach (var note in notes) 
            {
                note.DisplayInfo(); 
            }
        }
    }
}
