namespace _4._1.Open
{
    using _4._1;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;

    internal class DeserializeBin : IOpen
    {
        
        public List<Note> OpenNew(string fileName)
        {
            List<Note> notes=new List<Note>();
            IFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
#pragma warning disable SYSLIB0011
                notes = (List<Note>)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011
            }
            return notes;
        }

        public List<Note> OpenAdd(List<Note> notes, string fileName)
        {
            if(notes==null)
                notes= new List<Note>();
            List<Note> myList = new List<Note>();
            IFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
#pragma warning disable SYSLIB0011
                myList = (List<Note>)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011
            }

            int j;
            for (int i = 0; i < myList.Count; i++)
            {
                for (j = 0; j < notes.Count; j++)
                {
                    if (myList[i].Equals(notes[j]))
                        break;
                }
                if(j==notes.Count)
                    notes.Add(myList[i]);
            }
            return notes;
        }
    }
}
