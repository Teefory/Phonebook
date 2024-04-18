using System.Collections.Generic;

namespace _4._1.Open
{
    internal interface IOpen
    {
        
        List<Note> OpenNew(string fileName);
        List<Note> OpenAdd(List<Note> notes, string fileName);
        
    }
}
