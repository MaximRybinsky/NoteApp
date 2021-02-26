using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;


namespace NoteApp
{
    public static class ProjectManager
    {
        /// <summary>
        /// Путь сохранения и название сохраняемого файла
        /// </summary>
        private static string _savePath = "C:\\Users\\Максим\\Documents\\NoteApp.notes";

        /// <summary>
        /// Метод для сохранения данных
        /// </summary>
        public static void SaveToFile(Note note)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(_savePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, note);
            }
        }

        /// <summary>
        /// Метод для загрузки данных
        /// </summary>
        public static Note LoadFromFile()
        {
            Note readNote = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(_savePath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                readNote = (Note)serializer.Deserialize<Note>(reader);
            }
            return readNote;
        }
    }
}
