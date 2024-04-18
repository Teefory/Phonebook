using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.CodeAnalysis;
using static System.String;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


using _4._1.Save;
using _4._1.Open;

namespace _4._1
{

    public partial class MainForm : Form
    {

        private int sa;
        private bool Chenge = false;
        public List<Note> PhoneNote { get; set;}
        private int current;
        // private int Che = 0;
        public MainForm()
        {
            InitializeComponent();
            PhoneNote = new List<Note>();
            current = -1;
        }

        private void PrintElement()
        {
            try
            {
                if ((current >= 0) && (current < PhoneNote.Count))
                {
                    // если есть что выводить
                    // MyRecord - запись списка PhoneNote номер current
                    Note MyRecord = PhoneNote[current];
                    // записываем в соответствующие элементы на форме 
                    // поля из записи MyRecord 

                    LastName.Text = MyRecord.LastName;
                    Name.Text = MyRecord.Name;
                    Patronymic.Text = MyRecord.Patronymic;
                    Phone.Text = MyRecord.Phone;
                    Street.Text = MyRecord.Street;
                    House.Value = MyRecord.House;
                    Apartament.Value = MyRecord.Apartament;
                }
                else // если current равно -1, т. е. список пуст
                {   // очистить поля формы 
                    //string Empty;
                    LastName.Text = "";
                    Name.Text = "";
                    Patronymic.Text = "";
                    Street.Text = "";
                    House.Value = 1;
                    Apartament.Value = 1;
                    Phone.Text = "";
                }
                //обновление строки состояния

                NumberToolStripStatusLabel.Text = (current + 1).ToString();
                QuantityToolStripStatusLabel.Text = PhoneNote.Count.ToString();
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // создаем запись - экземпляр класса Note
            Note MyRecord = new Note();

            // создаем экземпляр формы AddForm
            AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Add);

            // открываем форму для добавления записи
            _AddForm.ShowDialog();
            // текущей записью становится последняя
            current = PhoneNote.Count;

            // добавляем к списку PhoneNote новый элемент - запись MyRecord,
            // взятую из формы AddForm
            int i;
            for (i = 0; i < PhoneNote.Count; i++)
            {
                if (MyRecord.Equals(PhoneNote[i]))
                    break;
            }
            if (i == PhoneNote.Count)
            {
                PhoneNote.Add(_AddForm.MyRecord);
                PrintElement();
            }

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneNote.Count > 0)
            {
                // создаем запись - экземпляр класса Note
                Note MyRecord = new Note();
                // определяем поля записи
                // (берем значения из соответствующих компонентов на форме)
                MyRecord.LastName = LastName.Text;
                MyRecord.Name = Name.Text;
                MyRecord.Patronymic = Patronymic.Text;
                MyRecord.Phone = Phone.Text;
                MyRecord.Street = Street.Text;
                MyRecord.House = (ushort)House.Value;
                MyRecord.Apartament = (ushort)Apartament.Value;
                // создаем экземпляр формы и открываем эту форму
                //AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Edit);
                AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Edit);
                _AddForm.ShowDialog();
                // изменяем текущую запись
                int i;
                for (i = 0; i < PhoneNote.Count; i++)
                {
                    if (MyRecord.Equals(PhoneNote[i]))
                        break;
                }
                if (i == PhoneNote.Count)
                {
                    //PhoneNote.Add(_AddForm.MyRecord);
                    PhoneNote[current] = _AddForm.MyRecord;
                    PrintElement();
                }
                //PhoneNote[current] = _AddForm.MyRecord;
            }
           // PrintElement();

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (current > 0)
            {
                current--;   // уменьшаем номер текущей записи на 1
                PrintElement();  // выводим элемент с номером current
            }
            else if (current < 0)
                MessageBox.Show(@"Еще не добавлено записей.");
            else
                MessageBox.Show(@"Эта запись первая.");

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (current + 1 < PhoneNote.Count())
            {
                current++;   // уменьшаем номер текущей записи на 1
                PrintElement();  // выводим элемент с номером current
            }
            else if (PhoneNote.Count() == 0)
                MessageBox.Show(@"Еще не добавлено записей.");
            else
                MessageBox.Show(@"Эта запись последняя.");
        }
        
        private ISave saveBehavior;
        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Chenge = true;
            saveFileDialog1.Filter = @"txt files(*.txt) | *.txt| xml files(*.xml) | *.xml| json files(*.json) | *.json| dat files(*dat) | *.dat";
            //saveFileDialog1.Filter = @"txt files(*.txt) | *.txt| xml files(*.xml) | *.xml";
            // saveFileDialog1.Filter = "txt files(*.txt) | *.txt | xml files(*.xml) | *xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            // Если в диалоговом окне нажали ОК
            {
                try
                {
                    this.saveBehavior = SaveCreater.Creater(saveFileDialog1.FileName);
                    // обработчик исключительных ситуаций
                    // используя sw (экземпляр класса StreamWriter),
                    // создаем файл с заданным в диалоговом окне именем
                    //string path = Path.GetExtension(this.saveFileDialog1.FileName);
                    switch (Path.GetExtension(saveFileDialog1.FileName))
                    {
                        case ".txt":
                            saveBehavior.Save(PhoneNote, saveFileDialog1.FileName);
                            break;
                        case ".xml":
                            saveBehavior.Save(PhoneNote, saveFileDialog1.FileName);
                            break;
                        case ".json":
                            saveBehavior.Save(PhoneNote, saveFileDialog1.FileName);
                            break;
                        case ".dat":
                            saveBehavior.Save(PhoneNote, saveFileDialog1.FileName);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // перехватываем ошибку
                    // выводим информацию об ошибке
                    MessageBox.Show("Не удалось сохранить данные! Ошибка: " +
                                    ex.Message);
                }
            }
        }
        private IOpen openfile;
        private void перезаписатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            if (this.PhoneNote.Count != 0)
            {
                Closed_form save = new Closed_form(true);
                Hide();
                save.ShowDialog();
                if (save.chenge)
                    сохранитьToolStripMenuItem1_Click(sender, e);
                Show();
                PhoneNote.Clear();
            }
            openFileDialog1.Filter = @"txt files(*.txt) | *.txt| xml files(*.xml) | *.xml| json files(*.json) | *.json| dat files(*.dat) | *.dat";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.openfile = OpenCreater.Creater(openFileDialog1.FileName);
                // если в диалоговом окне нажали ОК

                // обработчик исключительных ситуаций
                // считываем из указанного в диалоговом окне файла
                switch (Path.GetExtension(this.openFileDialog1.FileName))
                {
                    case ".txt":
                        {
                            try
                            {
                                PhoneNote = openfile.OpenNew(openFileDialog1.FileName);
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
                                PhoneNote = openfile.OpenNew(openFileDialog1.FileName);
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
                                PhoneNote = openfile.OpenNew(openFileDialog1.FileName);
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
                                PhoneNote = openfile.OpenNew(openFileDialog1.FileName);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("dat файла не существует");
                            }
                        }
                        break;
                }
                // если список пуст, то current устанавливаем в -1,
                // иначе текущей является первая с начала запись (номер 0)
                if (PhoneNote.Count == 0)
                    current = -1;
                else
                    current = 0;

                // выводим текущий элемент
                PrintElement();
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                openFileDialog1.Filter = "txt files(*.txt) | *.txt| xml files(*.xml) | *.xml| json files(*.json) | *.json| dat files(*dat) | *.dat";
                //openFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|xml файл(*.xml)|*.xml";
                //openFileDialog1.Filter = "txt files(*.txt) | *.txt | xml files(*.xml) | *xml";
                //Note MyRecord;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                // если в диалоговом окне нажали ОК
                {
                    this.openfile = OpenCreater.Creater(openFileDialog1.FileName);

                    switch (Path.GetExtension(this.openFileDialog1.FileName))
                    {
                        case ".txt":
                            {
                                try
                                {
                                    PhoneNote = openfile.OpenAdd(this.PhoneNote, openFileDialog1.FileName);
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
                                    PhoneNote = openfile.OpenAdd(this.PhoneNote, openFileDialog1.FileName);
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
                                    PhoneNote = openfile.OpenAdd(this.PhoneNote, openFileDialog1.FileName);
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
                                    PhoneNote = openfile.OpenAdd(this.PhoneNote, openFileDialog1.FileName);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("dat файла не существует");
                                }
                            }
                            break;
                    }
                    // если список пуст, то current устанавливаем в -1,
                    // иначе текущей является первая с начала запись (номер 0)
                    if (PhoneNote.Count == 0) current = -1;
                    else current = 0;
                    // выводим текущий элемент
                    PrintElement();
                }
            }

        //private void перезаписатьToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "txt files(*.txt) | *.txt| xml files(*.xml) | *.xml| json files(*.json) | *.json| dat files(*dat) | *.dat";
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    { 

        //    }    
        //}
        private void прпр_FormClosing(object sender, FormClosingEventArgs e)
            {
                //не сохранились
                if (Chenge == false)
                {
                    DialogResult result = MessageBox.Show("Сохранить изменения?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //сохраняем
                        saveFileDialog1.FilterIndex = 1;
                        saveFileDialog1.Filter = "Текстовый файл(*.txt)|*.txt|xml файл(*.xml)|*.xml|Бинарный файл(*.dat)|*.dat|json файл(*.json)|*.json";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            //сохраняем
                            сохранитьToolStripMenuItem1_Click(sender, e);
                            Chenge = true;
                        }
                        e.Cancel = false;
                    }
                    else if (result == DialogResult.No)
                    {
                        e.Cancel = false;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }


            }

            private void QuantityToolStripStatusLabel_Click(object sender, EventArgs e)
            {

            }

            private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void поискПоФИОToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SearchNameForm _Search = new SearchNameForm(PhoneNote);
                _Search.ShowDialog();

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void поискПоТелефонуToolStripMenuItem_Click(object sender, EventArgs e)
            {
                PhoneForm _Search = new PhoneForm(PhoneNote);
                _Search.ShowDialog();

            }

            private void поискПоАдресуToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SearchAdressForm _Search = new SearchAdressForm(PhoneNote);
                _Search.ShowDialog();

            }

            private void поФамилииToolStripMenuItem_Click(object sender, EventArgs e)

            {
                if (PhoneNote.Count > 0)    // если список не пуст
                {
                    // сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByLastName());
                    current = 0;        // задаем номер текущего элемента
                    PrintElement(); // вывод текущего элемента
                }
            }

            private void поКвартиреToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)
                {
                    PhoneNote.Sort(new CompareByApartamen());
                    current = 0;
                    PrintElement();
                }

            }

            private void поИмениToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)
                {
                    PhoneNote.Sort(new CompareByName());
                    current = 0;
                    PrintElement();
                }

            }

            private void поОтчествуToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)
                {
                    PhoneNote.Sort(new CompareByPatronymic());
                    current = 0;
                    PrintElement();
                }

            }

            private void поУлицеToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)
                {
                    PhoneNote.Sort(new CompareByStreet());
                    current = 0;
                    PrintElement();
                }

            }

            private void поДомуToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)
                {
                    PhoneNote.Sort(new CompareByHouse());
                    current = 0;
                    PrintElement();
                }

            }

            private void поТелефонуToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)
                {
                    PhoneNote.Sort(new CompareByPhone());
                    current = 0;
                    PrintElement();
                }

            }

        //private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (PhoneNote.Count > 0)
        //    {
        //        создаем запись -экземпляр класса Note
        //            Note MyRecord = new Note();
        //        определяем поля записи
        //        (берем значения из соответствующих компонентов на форме)
        //            MyRecord.LastName = LastName.Text;
        //        MyRecord.Name = Name.Text;
        //        MyRecord.Patronymic = Patronymic.Text;
        //        MyRecord.Phone = Phone.Text;
        //        MyRecord.Street = Street.Text;
        //        MyRecord.House = (ushort)House.Value;
        //        MyRecord.Apartament = (ushort)Apartament.Value;
        //        создаем экземпляр формы и открываем эту форму
        //       AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Edit);
        //        AddForm _AddForm = new AddForm(MyRecord, AddOrEdit.Edit);
        //        _AddForm.ShowDialog();
        //        изменяем текущую запись
        //       PhoneNote[current] = _AddForm.MyRecord;
        //    }
        //    PrintElement();

        //}

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count > 0)    // если список не пуст
                {
                    // сортировка списка по фамилии
                    PhoneNote.Sort(new CompareByLastName1());
                    current = 0;        // задаем номер текущего элемента
                    PrintElement(); // вывод текущего элемента
                }
            }

            private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (PhoneNote.Count != 0)
                {
                    PhoneNote.RemoveAt(current);
                    Chenge = true;
                    if (current == PhoneNote.Count)
                        current--;
                    PrintElement();
                }
                else
                    MessageBox.Show("В справочнике нет элементов.");
            }

       
    }
    class CompareByLastName : IComparer<Note>
        {
            public static int i = 1;
            public int Compare(Note x, Note y)
            {
                //return string.Compare(x.LastName, y.LastName) * i;
                return x.LastName.CompareTo(y.LastName);
            }
        }
        class CompareByLastName1 : IComparer<Note>
        {
            public static int i = 1;
            public int Compare(Note x, Note y)
            {
                //return string.Compare(x.LastName, y.LastName) * i;
                return y.LastName.CompareTo(x.LastName);
            }
        }
        class CompareByApartamen : IComparer<Note>
        {
            #region IComparer<Note> Members
            public int Compare(Note x, Note y)
            {
                //return string.Compare(x.Apartamen, y.Apartamen);
                return x.Apartament.CompareTo(y.Apartament);
            }
            #endregion
        }
        class CompareByName : IComparer<Note>
        {

            #region IComparer<Note> Members
            public int Compare(Note x, Note y)
            {
                return string.Compare(x.Name, y.Name);
                //return x.Name.CompareTo(y.Name);
            }
            #endregion
        }
        class CompareByPatronymic : IComparer<Note>
        {

            #region IComparer<Note> Members
            public int Compare(Note x, Note y)
            {
                return string.Compare(x.Patronymic, y.Patronymic);
                //return x.Patronymic.CompareTo(y.Patronymic);
            }
            #endregion
        }
        class CompareByStreet : IComparer<Note>
        {

            #region IComparer<Note> Members
            public int Compare(Note x, Note y)
            {
                return string.Compare(x.Street, y.Street);
                //return x.Street.CompareTo(y.Street);
            }
            #endregion
        }
        class CompareByHouse : IComparer<Note>
        {

            #region IComparer<Note> Members
            public int Compare(Note x, Note y)
            {
                return x.House.CompareTo(y.House);
            }
            #endregion
        }
        class CompareByPhone : IComparer<Note>
        {
            #region IComparer<Note> Members
            public int Compare(Note x, Note y)
            {
                return string.Compare(x.Phone, y.Phone);
                //return x.Phone.CompareTo(y.Phone);
            }
            #endregion
        }

    } 


