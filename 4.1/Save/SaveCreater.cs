using _4._1.Open;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _4._1.Save;
using System.Windows.Forms;



namespace _4._1.Save
{
    internal class SaveCreater
    {
        private static ISave openfile;
        public static ISave Creater(string fileName)
        {
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                    {
                        try
                        {
                            openfile = new SaveTXT();
                        }
                        catch (Exception ex) // если произошла ошибка
                        {
                            // выводим сообщение об ошибке
                            MessageBox.Show("При открытии файла произошла ошибка: " + ex.Message);
                        }
                    }
                    break;
                case ".xml":
                    {
                        try
                        {
                            openfile = new SerializeXML();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("xml файла не существует");
                        }
                    }
                    break;
                case ".json":
                    {
                        try
                        {
                            openfile = new SerializeJSON();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("json файла не существует");
                        }
                    }
                    break;
                case ".dat":
                    {
                        try
                        {
                            openfile = new SerializeBin();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("dat файла не существует");
                        }
                    }
                    break;
            }
            return openfile;
        }
    }
}
