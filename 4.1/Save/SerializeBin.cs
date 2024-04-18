using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _4._1.Save
{
    internal class SerializeBin : ISave
    {
        
        public void Save(List<Note> notes, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
#pragma warning disable SYSLIB0011
            formatter.Serialize(stream, notes);
#pragma warning restore SYSLIB0011
            stream.Close();
        }
    }
}
