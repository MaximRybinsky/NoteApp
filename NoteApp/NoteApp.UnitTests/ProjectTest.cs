using NUnit.Framework;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        [Test(Description = "Позитивный тест геттера и сеттера Notes")]
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
                "Геттер или сеттер Notes возвращает неправильный экземпляр класса Note");
        }
    }
}
