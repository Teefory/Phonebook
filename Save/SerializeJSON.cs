namespace Laba_4._1.Save
{
    using System.Text.Json;

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
