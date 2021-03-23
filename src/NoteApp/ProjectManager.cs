using Newtonsoft.Json;
using System;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Реализует чтение и запись проекта в файл
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Возвращает путь по умолчанию
        /// </summary>
        public static string DefaultPath { get; private set; } = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\Rybinsky\\NoteApp\\NoteApp.notes";

        /// <summary>
        /// Метод для сохранения данных
        /// </summary>
        /// <param name="project">Сохраняемый проект</param>
        /// <param name="fileName">Полное имя сохраняемого файла</param>
        public static void SaveToFile(Project project, string fileName)
        {
            //Если папка отсутствует - создать
            var folder = Path.GetDirectoryName(fileName);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            //Сериализовать
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
        /// <param name="fileName">Полное имя файла для чтения</param>
        /// <returns>Считанный проект, если повреждён - пустой проект</returns>
        public static Project LoadFromFile(string fileName)
        {
            var readProject = new Project();
            //Загрузить если найден. Иначе - вернуть пустой проект
            if (File.Exists(fileName)) 
            {
                //Если файл поврежден, возвращает пустой проект
                try
                {
                    var serializer = new JsonSerializer();
                    using (var sr = new StreamReader(fileName))
                    using (var reader = new JsonTextReader(sr))
                    readProject = (Project)serializer.Deserialize<Project>(reader);
                }
                catch
                {
                    return new Project();
                }
                if (readProject != null)
                {
                    return readProject;
                }
            }
            return new Project();
        }
    }
}
