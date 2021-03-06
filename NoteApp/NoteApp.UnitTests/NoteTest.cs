using System;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {
        private Note _note;

        [SetUp]
        public void Note_Init()
        {
            _note = new Note();
        }

        [Test(Description = "Позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            //var actual;
            //var expected;

            //Assert.AreEqual(actual, expected, 
            //    "");
        }

        [Test(Description = "Позитивный тест сеттера Title")]
        public void TestTitleSet_CorrectValue()
        {
            //var actual;
            //var expected;

            //Assert.AreEqual(actual, expected, 
            //    "");
        }

        [Test(Description = "Позитивный тест сеттера Title")]
        // Изменить название
        public void TestTitleSet_CorrectValue_Untitled()
        {
            //var actual;
            //var expected;

            //Assert.AreEqual(actual, expected, 
            //    "");
        }

        [Test(Description = "Негативный тест геттера Title")]
        public void TestTitleGet_UncorrectValue()
        {
            //var actual;
            //var expected;

            //Assert.AreEqual(actual, expected, 
            //    "");
        }





        [Test(Description = "Позитивный тест сеттера Category")]
        [Ignore("Тест идентичен тесту геттера")]
        public void TestCategorySet_CorrectValue()
        {
            var expected = NoteCategory.Home;
            _note.Category = expected;
            var actual = _note.Category;

            Assert.AreEqual(expected, actual,
                "Сеттер Category возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Home;
            _note.Category = expected;
            var actual = _note.Category;

            Assert.AreEqual(expected, actual, 
                "Геттер Category возвращает неправильный объект");
        }





        [Test(Description = "Позитивный тест сеттера Text")]
        [Ignore("Тест идентичен тесту геттера")]
        public void TestTextSet_CorrectValue()
        {
            var expected = "Hello, World!";
            _note.Text = expected;
            var actual = _note.Text;

            Assert.AreEqual(expected, actual,
                "Сеттер Text возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var expected = "Hello, World!";
            _note.Text = expected;
            var actual = _note.Text;

            Assert.AreEqual(expected, actual,
                "Геттер Text возвращает неправильный объект");
        }





        [Test(Description = "Позитивный тест сеттера Created")]
        [Ignore("Сеттер под модификатором доступа private")]
        public void TestCreatedtSet_CorrectValue()
        {
            var expected = DateTime.Now;
            //_note.Created = expected;
            var actual = _note.Text;

            Assert.AreEqual(expected, actual,
                "Сеттер Created возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера Created")]
        public void TestCreatedtGet_CorrectValue()
        {
            var expected = DateTime.Now;
            var actual = _note.Created;

            Assert.AreEqual(expected, actual,
                "Геттер Created возвращает неправильный объект");
        }





        [Test(Description = "Позитивный тест сеттера Modified")]
        [Ignore("Сеттер под модификатором доступа private")]
        public void TestModifiedtSet_CorrectValue()
        {
            var expected = DateTime.Now;
            //_note.Modified = expected;
            var actual = _note.Text;

            Assert.AreEqual(expected, actual,
                "Сеттер Modified возвращает неправильный объект");
        }

        [Test(Description = "Позитивный тест геттера Modified")]
        public void TestModifiedGet_CorrectValue()
        {
            var expected = DateTime.Now;
            var actual = _note.Created;

            Assert.AreEqual(expected, actual,
                "Геттер Modified возвращает неправильный объект");
        }



        [Test(Description = "Позитивный тест метода Clone")]
        public void TestClone_CorrectValue()
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

        //Для конструктора по умолчанию???
    }
}
