using System;


namespace NoteApp
{
    public class Note : ICloneable
    {
        /// <summary>
        /// Имя заметки
        /// </summary>
        private string _name;

        /// <summary>
        /// Свойства имени заметки
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина строки больше 50 символов");
                }
                else
                {
                    {
                        _name = value;
                    }
                }
            }
        }

        /// <summary>
        /// Категория заметки
        /// </summary>
        private CategoryOfNote _category;

        /// <summary>
        /// Свойства категории заметки
        /// </summary>
        public CategoryOfNote Category
        {
            get;
            set;
        }

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _text;

        /// <summary>
        /// Свойства текста заметки
        /// </summary>
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Время создания заметки
        /// </summary>
        private DateTime _timeOfCreation;

        /// <summary>
        /// Свойства времени создания заметки
        /// </summary>
        public DateTime TimeOfCreation
        {
            get;
            private set;
        }

        /// <summary>
        /// Время последнего изменения заметки
        /// </summary>
        private DateTime _timeOfLastChange;

        /// <summary>
        /// Свойства времени последнего изменения заметки
        /// </summary>
        public DateTime TimeOfLastChange
        {
            get;
            private set;
        }

        /// <summary>
        /// Реализация интерфейса IClonable
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Начальный конструктор
        /// </summary>
        public Note()
        {
            _name = "Без названия";
            //Присвоение имени работает, а вот время почему-то игнорируется
            _timeOfLastChange = DateTime.Now;
        }
    }
}
