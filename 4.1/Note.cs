using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    [Serializable]
    public class Note
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Street { get; set; }
        public ushort House { get; set; }
        public ushort Apartament { get; set; }
        public string Phone { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Note temp)
            {
                if (temp.LastName == LastName && temp.Name == Name && temp.Patronymic == Patronymic && temp.Street
                    == Street && temp.House == House && temp.Apartament == Apartament && temp.Phone == Phone)
                    return true;
            }
            return false;
        }
    }

}
