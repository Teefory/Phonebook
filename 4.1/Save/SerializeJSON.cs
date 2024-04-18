using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace _4._1.Save
{
    internal class SerializeJSON : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(notes, options);
            File.WriteAllText(fileName, json);

        }
    }
}



