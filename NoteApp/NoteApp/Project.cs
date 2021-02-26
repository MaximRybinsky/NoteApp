using System;
using System.Collections.Generic;
using System.Text;


namespace NoteApp
{
    public class Project
    {
        /// <summary>
        /// Список всех заметок
        /// </summary>
        private List<Note> _listOfNotes;

        /// <summary>
        /// Свойства списка заметок
        /// </summary>
        public List<Note> ListOfNotes
        {
            get;
            set;
        }
    }
}
