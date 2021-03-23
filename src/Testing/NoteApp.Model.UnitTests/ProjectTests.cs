using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTests
    {
        /// <summary>
        /// Экземпляр класса <see cref="Note"/> для проведения тестов
        /// </summary>
        private Note _note;

        /// <summary>
        /// Экземпляр класса <see cref="Project"/> для проведения тестов
        /// </summary>
        private Project _project;

        [SetUp]
        public void Project_Init()
        {
            _note = new Note();
            _project = new Project();
        }

        [Test(Description = "Позитивный тест геттера и сеттера Notes")]
        public void Notes_CorrectValue_ReturnsSameValue()
        {
            //Setup - инициализация проекта вынесена в атрибут [SetUp]
            var expected = _note;

            //Act
            _project.Notes.Add(_note);
            var actual = _project.Notes[0];

            //Assert
            Assert.AreEqual(expected, actual, 
                "Геттер или сеттер Notes возвращает неправильный " +
                "экземпляр класса Note");
        }

        [Test(Description = "Позитивный тест геттера и сеттера " +
            "SelectedNoteIndex")]
        public void SelectedNoteIndex_CorrectValue_ReturnsSameValue()
        {
            //Setup - инициализация проекта вынесена в атрибут [SetUp]
            var expected = 35;

            //Act
            _project.SelectedNoteIndex = 35;
            var actual = _project.SelectedNoteIndex;

            //Assert
            Assert.AreEqual(expected, actual,
                "Геттер или сеттер SelectedNoteIndex возвращает " +
                "неправильное значение");
        }


        [Test(Description = "Позитивный тест метода Sort")]
        public void Sort_CorrectValue_ReturnsSortedList()
        {
            //Setup - инициализация проекта вынесена в атрибут [SetUp]
            InsertNote("FirstNote", _project, NoteCategory.Other);
            InsertNote("SecondNote", _project, NoteCategory.Other);
            InsertNote("ThirdNote", _project, NoteCategory.Other);

            var secondProject = new Project();
            InsertNote("ThirdNote", secondProject, NoteCategory.Other);
            InsertNote("SecondNote", secondProject, NoteCategory.Other);
            InsertNote("FirstNote", secondProject, NoteCategory.Other);
            var expected = secondProject.Notes;

            //Act
            var actual = _project.SortNotes(_project.Notes);

            //Assert
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i].Title, actual[i].Title,
                    "Метод Sort возвращает Notes " +
                    "в неправильной последовательности");
            }
        }

        [Test(Description = "Позитивный тест метода Sort " +
            "с фильтром по конкретной категории")]
        public void CategorySort_CorrectValue_ReturnsSortedList()
        {
            //Setup - инициализация проекта вынесена в атрибут [SetUp]
            InsertNote("FirstNote", _project, NoteCategory.Finance);
            InsertNote("SecondNote", _project, NoteCategory.Work);
            InsertNote("ThirdNote", _project, NoteCategory.Finance);

            var secondProject = new Project();
            InsertNote("ThirdNote", secondProject, NoteCategory.Finance);
            InsertNote("FirstNote", secondProject, NoteCategory.Finance);
            var expected = secondProject.Notes;

            //Act
            _project.Notes = _project.SortNotes(_project.Notes, NoteCategory.Finance);
            var actual = _project.Notes;

            //Assert
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected[i].Title, actual[i].Title,
                    "Метод Sort возвращает Notes " +
                    "в неправильной последовательности");
            }
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected[i].Category, actual[i].Category,
                    "Метод Sort возвращает Notes " +
                    "с неправильным значением категории");
            }
        }

        /// <summary>
        /// Вспомогательный метод заполнения списка
        /// </summary>
        /// <param name="testTitle"></param>
        /// <param name="tempProject"></param>
        private void InsertNote(string testTitle, 
            Project testProject, NoteCategory testCategory)
        {
            //Без паузы между созданием новых заметок, 
            //сравнение времени не бутет корректно
            System.Threading.Thread.Sleep(10);

            var testNote = new Note();
            testNote.Title = testTitle;
            testNote.Category = testCategory;
            testProject.Notes.Add(testNote);
        }
    }
}
