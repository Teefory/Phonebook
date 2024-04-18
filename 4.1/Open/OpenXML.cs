using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _4._1.Open
{
    internal class OpenXML : IOpen
    {
        public List<Note> OpenNew(String fileName)
        {
            List<Note> notes =new List<Note>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                Note node = new Note();
                foreach (XmlNode cnode in xnode.ChildNodes)
                {
                    /*//if (cnode.Name == "Lastname") node.LastName = cnode.InnerText;
                    //if (cnode.Name == "Name") node.Name = cnode.InnerText;
                    //if (cnode.Name == "Patronymic") node.Patronymic = cnode.InnerText;
                    //if (cnode.Name == "Street") node.Street = cnode.InnerText;
                    //if (cnode.Name == "House") node.House = Convert.ToUInt16(cnode.InnerText);
                    //if (cnode.Name == "Flat") node.Flat = Convert.ToUInt16(cnode.InnerText);
                    //if (cnode.Name == "Phone") node.Phone = cnode.InnerText;*/
                    switch (cnode.Name)
                    {
                        case "Lastname":
                            node.LastName = cnode.InnerText;
                            break;
                        case "Name":
                            node.Name = cnode.InnerText;
                            break;
                        case "Patronymic":
                            node.Patronymic = cnode.InnerText;
                            break;
                        case "Street":
                            node.Street = cnode.InnerText;
                            break;
                        case "House":
                            node.House = Convert.ToUInt16(cnode.InnerText);
                            break;
                        case "Apartament":
                            node.Apartament = Convert.ToUInt16(cnode.InnerText);
                            break;
                        case "Phone":
                            node.Phone = cnode.InnerText;
                            break;
                    }
                }

                if (notes.Count != 0)
                {
                    int i;
                    for (i = 0; i < notes.Count; i++)
                        if (node.Equals(notes))
                            break;
                    if (i == notes.Count)
                        notes.Add(node);
                }
                else
                    notes.Add(node);
            }
            return notes;
        }
        
        public List<Note> OpenAdd(List<Note> notes, String fileName)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                Note node = new Note();
                foreach (XmlNode cnode in xnode.ChildNodes)
                {
                    switch (cnode.Name)
                    {
                        case "Lastname":
                            node.LastName = cnode.InnerText;
                            break;
                        case "Name":
                            node.Name = cnode.InnerText;
                            break;
                        case "Patronymic":
                            node.Patronymic = cnode.InnerText;
                            break;
                        case "Street":
                            node.Street = cnode.InnerText;
                            break;
                        case "House":
                            node.House = Convert.ToUInt16(cnode.InnerText);
                            break;
                        case "Apartament":
                            node.Apartament = Convert.ToUInt16(cnode.InnerText);
                            break;
                        case "Phone":
                            node.Phone = cnode.InnerText;
                            break;
                    }
                }

                if (notes.Count != 0)
                {
                    int i;
                    for (i = 0; i < notes.Count; i++)
                        if (node.Equals(notes))
                            break;
                    if (i == notes.Count)
                        notes.Add(node);
                }
                else
                    notes.Add(node);
            }

            return notes;
        }
    }
}
