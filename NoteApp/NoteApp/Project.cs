using System.Collections.Generic;
using System.Linq;

namespace NoteApp
{
    /// <summary>
    /// Класс, хранящий список заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Свойства списка заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Возвращает и устанавливает индекс последней просматреваемой заметки
        /// </summary>
        public int SelectedNoteIndex { get; set; } = -1;

        /// <summary>
        /// Перегруженный метод, возвращающий список заметок отсортированный по дате изменения
        /// </summary>
        public List<Note> SortNotes(List<Note> notes)
        {
            var sortedNotes = notes.OrderByDescending(note => note.Modified).ToList();
            return sortedNotes;
        }

        /// <summary>
        /// Перегруженный метод, возвращающий список заметок конкретной категории
        /// </summary>
        public List<Note> SortNotes(List<Note> notes, NoteCategory category)
        {
            var categoryNotes = notes.Where(note => note.Category == category).ToList();
            var sortedNotes = categoryNotes.OrderByDescending(note => note.Modified).ToList();
            return sortedNotes;
        }
    }
}
