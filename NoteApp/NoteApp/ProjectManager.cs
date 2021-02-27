using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Реализует чтение и запись проекта в файл
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Метод для сохранения данных
        /// </summary>
        public static void SaveToFile(Project project, string fileName)
        {
            //var fileName = Environment.GetFolderPath
            //    (Environment.SpecialFolder.ApplicationData) + "\\NoteApp.notes";
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(fileName))
            using (var writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод для загрузки данных
        /// </summary>
        public static Project LoadFromFile(string fileName)
        {
            
            //var fileName = Environment.GetFolderPath
            //    (Environment.SpecialFolder.ApplicationData) + "\\NoteApp.notes";
            Project readProject = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader(fileName))
            using (var reader = new JsonTextReader(sr))
            {
                if (File.Exists(fileName))
                {
                    readProject = (Project)serializer.Deserialize<Project>(reader);
                }
                return readProject;
            }
        }
    }
}
