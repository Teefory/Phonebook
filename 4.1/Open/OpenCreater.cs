using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _4._1.Open
{
    internal class OpenCreater
    {
        private static IOpen openfile;
        public static IOpen Creater(string fileName)
        {
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                    {
                        try
                        {
                            openfile = new OpenTXT();
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
                            openfile = new DeserialezeXML();
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
                            openfile = new DeserializeJSON();
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
                            openfile = new DeserializeBin();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("bin файла не существует");
                        }
                    }
                    break;
            }
            return openfile;
        }
    }
}
