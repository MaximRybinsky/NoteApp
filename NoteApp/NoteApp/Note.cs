using System;

namespace NoteApp
{
    /// <summary>
    /// Заметка
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Имя заметки
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _text;

        /// <summary>
        /// Принимает и выдает значение имени заметки.
        /// Имя не больше 50 символов.
        /// Устанавливает время последнего изменения
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException
                        ("Слишком большое имя заметки: больше 50 символов");
                }
                else if (value == "")
                {
                    _title = "Без названия"; 
                    Modified = DateTime.Now;
                }
                else
                {
                    _title = value;
                    Modified = DateTime.Now;
                }
            }
        }

        /// <summary>
        /// Принимает и выдает значение категории заметки
        /// Устанавливает время последнего изменения
        /// </summary>
        public NoteCategory Category 
        {
            get
            {
                return _category;
            }
            set
            {
                if (value == null)
                {
                    _category = NoteCategory.Other;
                }
                else
                {
                    _category = value;
                }
                
                Modified = DateTime.Now;
            }
        }

        /// <summary>
        /// Принимает и выдает значение текста заметки
        /// Устанавливает время последнего изменения
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                Modified = DateTime.Now;
            }
        }

        /// <summary>
        /// Принимает и выдает значение времени создания заметки
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Принимает и выдает значение времени последнего изменения заметки
        /// </summary>
        public DateTime Modified { get; private set; }

        /// <summary>
        /// Начальный конструктор
        /// </summary>
        public Note()
        {
            Title = "Без названия";
            Category = NoteCategory.Other;
            Created = DateTime.Now;
            Modified = Created;
        }

        /// <summary>
        /// Реализация интерфейса IClonable
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
