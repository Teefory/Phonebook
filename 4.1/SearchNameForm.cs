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
    public partial class SearchNameForm : Form
    {
        List<Note> PhoneNote;
        public SearchNameForm(List<Note> _PhoneNote)
        {
            InitializeComponent();
            PhoneNote = _PhoneNote;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchNameForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
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
                if (MyRecord.LastName.Contains(LastNameTextBox.Text) &&
                MyRecord.Name.Contains(NameTextBox.Text) && MyRecord.Patronymic.Contains(PatronymicTextBox.Text))
                {
                    // увеличиваем счетчик найденных записей
                    i++;
                    // дописываем элемент и его номер к результату 
                    ResultsTextBox.Text = ResultsTextBox.Text + i.ToString() + ". " + MyRecord.LastName + " " + MyRecord.Name + " " + MyRecord.Patronymic + ", ул. " + MyRecord.Street + ", д." + MyRecord.House + ", кв. " + MyRecord.Apartament + ", тел. " + MyRecord.Phone + "\r\n";
                }
            }
            // если не найдено ни одной записи, выводим сообщение
            if (i == 0) ResultsTextBox.Text = "Записей, удовлетворяющих поставленным условиям, в списке абонентов нет! "; 

        }
    }
}
