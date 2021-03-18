using System.Collections.Generic;

namespace NoteApp
{
    /// <summary>
    /// Проект
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
        public List<Note> SortNotes(List<Note> list)
        {
            list.Sort((x, y) => y.Modified.CompareTo(x.Modified));
            return list;
        }

        /// <summary>
        /// Перегруженный метод, возвращающий список заметок конкретной категории
        /// </summary>
        public List<Note> SortNotes(List<Note> list, NoteCategory category)
        {
            var sorted = new List<Note>();

            foreach


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Category == category)
                {
                    sorted.Add(list[i]);
                }
            }


            sorted = SortNotes(list);
            return sorted;
        }
    }
}
