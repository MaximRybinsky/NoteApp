using System.Collections.Generic;
using System;

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
        public int SelectedNoteIndex { get; set; }

        /// <summary>
        /// Перегруженный метод, возвращающий список заметок отсортированный по дате изменения
        /// </summary>
        public List<Note> SortNotes()
        {
            //var categoryComparer = new CategoryComparer();
            //Notes.Sort(categoryComparer);
            return Notes;
        }

        /// <summary>
        /// Перегруженный метод, возвращающий список заметок конкретной категории
        /// </summary>
        public List<Note> SortNotes(NoteCategory category)
        {
            var sorted = new List<Note>();

            foreach(Note note in Notes)
            {
                sorted.Add(note);
            }

            sorted = SortNotes();
            return sorted;
        }
    }
}
