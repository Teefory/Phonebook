namespace Laba_4._1.Save
{
    internal class SaveTXT : ISave
    {
        public void Save(List<Note> notes, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (Note MyRecord in notes)
                {
                    sw.WriteLine(MyRecord.LastName);
                    sw.WriteLine(MyRecord.Name);
                    sw.WriteLine(MyRecord.Patronymic);
                    sw.WriteLine(MyRecord.Street);
                    sw.WriteLine(MyRecord.House);
                    sw.WriteLine(MyRecord.Flat);
                    sw.WriteLine(MyRecord.Phone);
                }
            }
        }

    }
}
