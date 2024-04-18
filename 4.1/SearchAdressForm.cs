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
    public partial class SearchAdressForm : Form
    {
        private List<Note> phoneNotes;
        public SearchAdressForm(List<Note> phoneNotes)
        {
            InitializeComponent();
            this.phoneNotes = phoneNotes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Street_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void House_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Apartament_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchAdressForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // очищаем окно для вывода результатов
            ResultsTextBox.Text = "";
            // количество найденных результатов
            int i = 0;
            // цикл for для каждого элемента списка - foreach
            foreach (Note MyRecord in phoneNotes)
            {
                // если выполняются условия поиска
                if (MyRecord.Street.Contains(StreetText.Text) && MyRecord.House == int.Parse(HouseText.Text)
                                                              && MyRecord.Apartament == int.Parse(ApartamentText.Text))
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
