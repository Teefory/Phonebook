using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
namespace _4._1.Save
{
    internal class SerializeXML : ISave
    { 
        public void Save(List<Note> notes,string fileName)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Note>));
            FileStream file = File.Create(fileName);
            writer.Serialize(file, notes);
            file.Close();
        }
    }
}
