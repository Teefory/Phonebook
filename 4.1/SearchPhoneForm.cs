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
    public partial class PhoneForm : Form
    {
        private List<Note> PhoneNote;

        public PhoneForm(List<Note> _PhoneNote)
        {
            InitializeComponent();
            this.PhoneNote = _PhoneNote;
        }

        private void Phone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SearchPhoneForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // очищаем окно для вывода результатов
            ResultsTextBox.Text = "";
            // количество найденных результатов
            int i = 0;
            // цикл for для каждого элемента списка - foreach
            foreach (Note MyRecord in PhoneNote)
            {
                // если выполняются условия поиска
                if (MyRecord.Phone.Contains(PhoneText.Text))
                {
                    // увеличиваем счетчик найденных записей
                    i++;
                    // дописываем элемент и его номер к результату 
                    ResultsTextBox.Text = ResultsTextBox.Text + i.ToString() + ". " + MyRecord.LastName + " " + MyRecord.Name + " " + MyRecord.Patronymic +
                                          ", ул. " + MyRecord.Street + ", д." + MyRecord.House + ", кв. " + MyRecord.Apartament + ", тел. " + MyRecord.Phone + "\r\n";
                }
            }
            // если не найдено ни одной записи, выводим сообщение
            if (i == 0) ResultsTextBox.Text = "Записей, удовлетворяющих поставленным условиям, в списке абонентов нет! ";
        }
    }
}

