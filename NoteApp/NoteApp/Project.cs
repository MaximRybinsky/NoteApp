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
    }
}
