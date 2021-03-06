using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        [Test(Description = "Позитивный тест сеттера Notes")]
        [Ignore("Тест идентичен тесту геттера")]
        public void TestNotesSet_CorrectValue()
        {
            // Setup
            Note note = new Note();
            Project project = new Project();

            project.Notes.Add(note);

            var expected = note;
            var actual = project.Notes[0];

            Assert.AreEqual(expected, actual, 
                "Сеттер Notes задаёт неправильный экземпляр класса Note");
        }

        [Test(Description = "Позитивный тест геттера Notes")]
        public void TestNotesGet_CorrectValue()
        {
            // Setup
            Note note = new Note();
            Project project = new Project();
            project.Notes.Add(note);

            //Act
            var expected = note;
            var actual = project.Notes[0];

            //Assert
            Assert.AreEqual(expected, actual, 
                "Геттер Notes возвращает неправильный экземпляр класса Note");
        }
    }
}
