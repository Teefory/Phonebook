using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;


namespace _4._1.Open
{
    internal class DeserialezeXML : IOpen
    {
        
        public List<Note> OpenNew(string fileName)
        {
            List<Note> notes = new List<Note>();
            XmlSerializer reader = new XmlSerializer(typeof(List<Note>));
            StreamReader file = new StreamReader(fileName);
            notes = (List<Note>)reader.Deserialize(file);
            file.Close();
            return notes;
        }

        public List<Note> OpenAdd(List<Note> notes, string fileName)
        {
            if (notes == null)
                notes = new List<Note>();
            List<Note> myList = new List<Note>();
            XmlSerializer reader = new XmlSerializer(typeof(List<Note>));
            StreamReader file = new StreamReader(fileName);
            myList = (List<Note>)reader.Deserialize(file);

            int j;
            for (int i = 0; i < myList.Count; i++)
            {
                for (j = 0; j < notes.Count; j++)
                {
                    if (myList[i].Equals(notes[j]))
                        break;
                }
                if (j == notes.Count)
                    notes.Add(myList[i]);
            }
            return notes;
        }
    }
}
