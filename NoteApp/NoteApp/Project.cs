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
        public List<Note> NotesList { get; set; }

        /// <summary>
        /// Начальный конструктор, создаёт экземпляр списка
        /// </summary>
        public Project()
        {
            NotesList = new List<Note>();
        }
    }
}
