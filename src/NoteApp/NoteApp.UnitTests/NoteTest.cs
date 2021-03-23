using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        /// <summary>
        /// Экземпляр класса <see cref="Note"/> для проведения тестов
        /// </summary>
        private Note _note;

        [SetUp]
        public void Note_Init()
        {
            _note = new Note();
        }

        [Test(Description = "Позитивный тест геттера и сеттера Title")]
        public void Title_CorrectValue_ReturnsSameValue()
        {
            var expected = "Test title for note";
            _note.Title = expected;
            var actual = _note.Title;

            Assert.AreEqual(actual, expected,
                "Геттер или сеттер Title возвращает неправильный текст");
        }

        [Test(Description = "Присвоение слишком большого значения: " +
            "больше 50 символов")]
        public void TitleSet_CorrectValue_Untitled()
        {
            var wrongTitle = "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";
            Assert.Throws<ArgumentException>(
                () => { _note.Title = wrongTitle; },
                    "Должно возникать исключение, если название длиннее 50 символов");
        }

        [Test(Description = "Присвоение пустой строки в качестве Title." +
            "Должно быть заменено на Без названия")]
        public void TitleSet_EmptyString()
        {
            var setup = "";
            var expected = "Без названия";
            _note.Title = setup;
            var actual = _note.Title;

            Assert.AreEqual(actual, expected,
                "Сеттер устанавливает неправильное название заметки");
        }

        [Test(Description = "Позитивный тест геттера и сеттера Category")]
        public void CategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Home;
            _note.Category = expected;
            var actual = _note.Category;

            Assert.AreEqual(expected, actual,
                "Геттер или сеттер Category возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера и сеттера Text")]
        public void TextGet_CorrectValue()
        {
            var expected = "Hello, World!";
            _note.Text = expected;
            var actual = _note.Text;

            Assert.AreEqual(expected, actual,
                "Геттер или сеттер Text возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера и сеттера Created")]
        [Ignore("Сеттер под модификатором доступа private")]
        public void CreatedtGet_CorrectValue()
        {
            var expected = DateTime.Today;
            var actual = _note.Created;

            Assert.AreEqual(expected, actual,
                "Геттер Created возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера и сеттера Modified")]
        [Ignore("Сеттер под модификатором доступа private")]
        public void ModifiedGet_CorrectValue()
        {
            var expected = DateTime.Now;
            var actual = _note.Created;

            Assert.AreEqual(expected, actual,
                "Геттер Modified возвращает неправильный объект");
        }



        [Test(Description = "Позитивный тест метода Clone")]
        public void Clone_CorrectValue()
        {
            Note expected = _note;
            var actual = (Note)_note.Clone();

            Assert.AreEqual(expected.Title, actual.Title, "Метод Clone устанавливает " +
            "неправильное значение Title");
            Assert.AreEqual(expected.Text, actual.Text, "Метод Clone устанавливает " +
           "неправильное значение Text");
            Assert.AreEqual(expected.Category, actual.Category, "Метод Clone устанавливает " +
           "неправильное значение Category");
            Assert.AreEqual(expected.Created, actual.Created, "Метод Clone устанавливает " +
           "неправильное значение Created");
            Assert.AreEqual(expected.Modified, actual.Modified, "Метод Clone устанавливает " +
           "неправильное значение Modified");
        }
    }
}
