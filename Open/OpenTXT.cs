namespace Laba_4._1.Open
{
    using Laba_4._1.Save;

    internal class OpenTXT : IOpen
    {
        public List<Note> OpenNew(string fileName)
        {
            List<Note> notes = new List<Note>();
            using (StreamReader sr = new StreamReader(fileName))
                while (!sr.EndOfStream)
                {
                    // пока не дошли до конца файла
                    // выделяем место под запись
                    Note myRecord = new Note();

                    // считываем значения полей записи из файла
                    myRecord.LastName = sr.ReadLine();
                    myRecord.Name = sr.ReadLine();
                    myRecord.Patronymic = sr.ReadLine();
                    myRecord.Street = sr.ReadLine();
                    myRecord.House = ushort.Parse(sr.ReadLine());
                    myRecord.Flat = ushort.Parse(sr.ReadLine());
                    myRecord.Phone = sr.ReadLine();
                    ////добавляем запись в список
                    if (notes.Count != 0)
                    {
                        int i;
                        for (i = 0; i < notes.Count; i++)
                            if (myRecord.Equals(notes))
                                break;
                        if (i == notes.Count)
                            notes.Add(myRecord);
                    }
                    else
                        notes.Add(myRecord);
                }
            return notes;
        }
        
        public List<Note> OpenAdd(List<Note> notes,string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
                while (!sr.EndOfStream)
                {
                    // пока не дошли до конца файла
                    // выделяем место под запись
                    Note myRecord = new Note();

                    // считываем значения полей записи из файла
                    myRecord.LastName = sr.ReadLine();
                    myRecord.Name = sr.ReadLine();
                    myRecord.Patronymic = sr.ReadLine();
                    myRecord.Street = sr.ReadLine();
                    myRecord.House = ushort.Parse(sr.ReadLine());
                    myRecord.Flat = ushort.Parse(sr.ReadLine());
                    myRecord.Phone = sr.ReadLine();
                    ////добавляем запись в список
                    if (notes.Count != 0)
                    {
                        int i;
                        for (i = 0; i < notes.Count; i++)
                            if (myRecord.Equals(notes[i]))
                                break;
                        if (i == notes.Count)
                            notes.Add(myRecord);
                    }
                    else
                        notes.Add(myRecord);
                }
            return notes;
        }
    }
}
