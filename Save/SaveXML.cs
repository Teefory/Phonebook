using System.Text;
using System.Xml;

namespace Laba_4._1.Save
{
    internal class SaveXML : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            // создание xml документа со строкой <?xml version="1.0" encoding="utf-8"?>
            XmlTextWriter textWritter = new XmlTextWriter(fileName, Encoding.UTF8);
            textWritter.WriteStartDocument();// запись заголовка документа
            textWritter.WriteStartElement("Notes"); // создание головы
            textWritter.WriteEndElement(); // закрываем голову
            textWritter.Close(); // закрываем документ

            XmlDocument document = new XmlDocument();// открываем документ
            document.Load(fileName);// загружаем из xml файла

            int i = 0;
            foreach (Note x in notes)
            {
                // Создаём XML-запись
                XmlElement element = document.CreateElement("Note");
                document.DocumentElement.AppendChild(element); // указываем родителя
                XmlAttribute attribute = document.CreateAttribute("id"); // создаем атрибут
                attribute.Value = i.ToString(); // устанавливаем значение атрибута
                element.Attributes.Append(attribute); // добавляем атрибут

                // Добавляем в запись данные
                XmlNode lastnameElem = document.CreateElement("Lastname"); // даем имя
                lastnameElem.InnerText = x.LastName; // и значение
                element.AppendChild(lastnameElem); // и указываем кому принадлежит

                XmlNode name = document.CreateElement("Name");
                name.InnerText = x.Name;
                element.AppendChild(name);

                XmlNode patronymic = document.CreateElement("Patronymic");
                patronymic.InnerText = x.Patronymic;
                element.AppendChild(patronymic);

                XmlNode street = document.CreateElement("Street");
                street.InnerText = x.Street;
                element.AppendChild(street);

                XmlNode house = document.CreateElement("House");
                house.InnerText = x.House.ToString();
                element.AppendChild(house);

                XmlNode flat = document.CreateElement("Flat");
                flat.InnerText = x.Flat.ToString();
                element.AppendChild(flat);

                XmlNode phone = document.CreateElement("Phone");
                phone.InnerText = x.Phone;
                element.AppendChild(phone);
                i++;
            }

            document.Save(fileName);
        }
    }
}