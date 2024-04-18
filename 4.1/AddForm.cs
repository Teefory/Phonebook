using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._1
{
    public partial class AddForm : Form
    {
        public Note MyRecord;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(Note _MyRecord, AddOrEdit MyType)
        {
            InitializeComponent();
            MyRecord = _MyRecord;
            // если форма открыта для добавления
            if (MyType == AddOrEdit.Add)
            {
                Text = "Добавление абонента";
                AddButton.Text = "Добавить";
            }
            else    // если форма открыта для изменения записи
            {
                Text = "Изменение абонента";
                AddButton.Text = "Изменить";
                // определяем значение компонентов на форме
                LastName.Text = MyRecord.LastName;
                Name.Text = MyRecord.Name;
                Patronymic.Text = MyRecord.Patronymic;
                Phone.Text = MyRecord.Phone;
                Street.Text = MyRecord.Street;
                House.Value = MyRecord.House;
                Apartament.Value = MyRecord.Apartament;
            }
        }
     
        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            // определяем поля записи -
            // берем значения из соответствующих компонентов на форме
            MyRecord.LastName = LastName.Text;
            MyRecord.Name = Name.Text;
            MyRecord.Patronymic = Patronymic.Text;
            MyRecord.Phone = Phone.Text;
            MyRecord.Street = Street.Text;
            MyRecord.House = (ushort)House.Value;
            MyRecord.Apartament = (ushort)Apartament.Value;
            Close();        // закрываем форму
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
        }
        
    }
    public enum AddOrEdit
    {
        Add,
        Edit
    }


}
