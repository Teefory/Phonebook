using System.Text.Json;

namespace Laba_4._1.Open
{
    internal class DeserializeJSON :IOpen
    {
        public List<Note> OpenNew(string fileName)
        {
            List<Note> notes=new List<Note>();
            string s = File.ReadAllText(fileName);
            notes = JsonSerializer.Deserialize<List<Note>>(s);
            return notes;
        }

        public List<Note> OpenAdd(List<Note> notes, string fileName)
        {
            if(notes==null)
                notes =new List<Note>();


            List<Note> myList = new List<Note>();
            string s = File.ReadAllText(fileName);
            myList = JsonSerializer.Deserialize<List<Note>>(s);

            int j;
            for (int i = 0; i < myList.Count; i++)
            {
                for (j = 0; j < notes.Count; j++)
                {
                    if (myList[i].Equals( notes[j]))
                        break;
                }
                if (j == notes.Count)
                    notes.Add(myList[i]);
            }
            return notes;
        }
    }
}
