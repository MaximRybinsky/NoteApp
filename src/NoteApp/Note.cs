using Newtonsoft.Json;
using System;

namespace NoteApp
{
    /// <summary>
    /// Заметка. Соедержит поля: имя, текст, категория, 
    /// время создания и последнего редактирования
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Имя заметки
        /// </summary>
        private string _title = "Untitled";

        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _category = NoteCategory.Other;

        /// <summary>
        /// Текст заметки
        /// </summary>
        private string _text;

        /// <summary>
        /// Возвращает или задает значение имени заметки.
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
                        ("Note name is too large: more than 50 characters");
                }
                else if (value == "")
                {
                    _title = "Untitled"; 
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
        /// Возвращает или задает значение категории заметки.
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
                _category = value;   
                Modified = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает или задает значение текста заметки.
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
        /// Возвращает значение времени создания заметки
        /// </summary>
        public DateTime Created { get; private set; } = DateTime.Now;

        /// <summary>
        /// Возвращает значение времени последнего изменения заметки
        /// </summary>
        public DateTime Modified { get; private set; } = DateTime.Now;

        /// <summary>
        /// Создает экземпляр <see cref="Note"> по умолчанию
        /// </summary>
        public Note()
        {
        }

        /// <summary>
        /// Создает экземпляр <see cref="Note"> для сериализации и десериализации
        /// </summary>
        /// <param name="title">Название заметки</param>
        /// <param name="text">Текст заметки</param>
        /// <param name="category">Категория заметки</param>
        /// <param name="created">Время создания заметки</param>
        /// <param name="modified">Время последнего редактирования заметки</param>
        [JsonConstructor]
        public Note(string title, string text, NoteCategory category,
            DateTime created, DateTime modified)
        {
            Title = title;
            Text = text;
            Category = category;
            Created = created;
            Modified = modified;
        }

        /// <summary>
        /// Конструктор с пользовательскими значениями 
        /// даты создания и последнего редактирования.
        /// Только для проведения тестов!
        /// </summary>
        /// <param name="testTime">Время создания</param>
        public Note(DateTime testTime)
        {
            Created = testTime;
            Modified = testTime;
        }

        /// <summary>
        /// Реализация интерфейса IClonable
        /// </summary>
        /// <returns>Клон заметки</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
