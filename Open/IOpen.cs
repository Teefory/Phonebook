namespace Laba_4._1.Open
{
    internal interface IOpen
    {
        List<Note> OpenNew(String fileName);
        List<Note> OpenAdd(List<Note> notes, String fileName);
    }
}
