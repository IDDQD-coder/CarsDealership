using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDB
{
    public partial class ManagerHome : Form
    {
        string position;
        public ManagerHome(string pos)
        {
            InitializeComponent();
            this.position = pos;
            this.Text = this.Text + " " + this.position;
            zaktextBox.Text = this.position;
        }
        public void ManagerHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new CreateDetail(this.position);
            frm.Show();
        }
        private void ClearInsert(object sender, EventArgs e)
        {
            vintextBox.Text = "";
            marktextBox.Text = "";
            modeltextBox.Text = "";
            yeartextBox.Text = "";
            typecomboBox.SelectedIndex = 0;
            colorcomboBox.SelectedIndex = 0;
            matherialcomboBox.SelectedIndex = 0;
            kppcomboBox.SelectedIndex = 0;
            enginecomboBox.SelectedIndex = 0;
            powertextBox.Text = "";
            pricetextBox.Text = "";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.CountOfDetailsNotInDealByName". При необходимости она может быть перемещена или удалена.
            this.countOfDetailsNotInDealByNameTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfDetailsNotInDealByName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.CountOfCarsNotInDealByMark". При необходимости она может быть перемещена или удалена.
            this.countOfCarsNotInDealByMarkTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfCarsNotInDealByMark);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.бД_автосалонаDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Managerslist". При необходимости она может быть перемещена или удалена.
            this.managerslistTableAdapter.Fill(this.бД_автосалонаDataSet.Managerslist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.бД_автосалонаDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Автомобиль". При необходимости она может быть перемещена или удалена.
            this.автомобильTableAdapter.Fill(this.бД_автосалонаDataSet.Автомобиль);
            this.sellsByMonthTableAdapter.Fill(this.бД_автосалонаDataSet.SellsByMonth, dateTimePicker1.Text);
            this.countOfDetailsNotInDealByNameTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfDetailsNotInDealByName);
            this.countOfCarsNotInDealByMarkTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfCarsNotInDealByMark);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vintextBox.Text.Length < 17) { MessageBox.Show("Некорректный vin"); return; }
            int? error = 0;
            автомобильTableAdapter.InsertCar(vintextBox.Text, postcomboBox.Text, this.position, marktextBox.Text, modeltextBox.Text, Convert.ToInt64(yeartextBox.Text),typecomboBox.Text, colorcomboBox.Text, matherialcomboBox.Text, kppcomboBox.Text, enginecomboBox.Text, Convert.ToInt32(powertextBox.Text), Convert.ToInt32(pricetextBox.Text), ref error);
            if (error == 0)
            {
                MessageBox.Show("Выполнено успешно","Добавление автомобиля");
                автомобильTableAdapter.Fill(this.бД_автосалонаDataSet.Автомобиль);
                if (!radioButton1.Checked) ClearInsert(sender,e);
                UpdateOst(sender, e);
            }
            if (error==1)
                MessageBox.Show("Повторяющийся VIN");
            if (error == 2)
                MessageBox.Show("Некорректный год выпуска");
            if (error == 3)
                MessageBox.Show("Нулевая мощность");
            if (error == 4)
                MessageBox.Show("Нулевая цена");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (searchtextBox.Text=="")
            {
                автомобильBindingSource.Filter = "";
                return;
            }
            if (searchtextBox.Text.Length < 17) { MessageBox.Show("Некорректный vin"); return; }
            автомобильBindingSource.Filter = "VIN='" + Convert.ToString(searchtextBox.Text)+"'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                автомобильBindingSource.RemoveCurrent();
                this.Validate();
                this.автомобильBindingSource.EndEdit();
                автомобильTableAdapter.Update(бД_автосалонаDataSet);
                UpdateOst(sender, e);
            }
            catch
            {
                this.автомобильTableAdapter.Fill(this.бД_автосалонаDataSet.Автомобиль);
                MessageBox.Show("Попытка удаления связанного значения", "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автомобильBindingSource.EndEdit();
            try
            {
                автомобильTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обновление значений невозможно", "ERROOR");
                Console.WriteLine(ex);
                this.автомобильTableAdapter.Fill(this.бД_автосалонаDataSet.Автомобиль);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            поставщикBindingSource1.Filter = "Название LIKE'" + searchnametextBox.Text + "%'";
            поставщикTableAdapter.Update(бД_автосалонаDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource1.EndEdit();
            try
            {
                поставщикTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обновление значений невозможно", "Изменение поставщика");
                Console.WriteLine(ex);
                this.поставщикTableAdapter.Fill(this.бД_автосалонаDataSet.Поставщик);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                поставщикBindingSource1.RemoveCurrent();
                this.Validate();
                this.поставщикBindingSource1.EndEdit();
                поставщикTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch
            {
                this.автомобильTableAdapter.Fill(this.бД_автосалонаDataSet.Автомобиль);
                MessageBox.Show("Попытка удаления связанного значения", "Удаление поставщика");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sotrphoneerrorProvider.Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            sotrfioerrorProvider.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (phonetextBox.TextLength<11)
            {
                MessageBox.Show("Введите корректный номер телефона", "Добавление сотрудника");
                return;
            }
            int? error = 0;
            сотрудникTableAdapter.InsertSotr(fiotextBox.Text, phonetextBox.Text,dolcomboBox.Text, ref error);
            if (error == 1)
            {
                sotrfioerrorProvider.SetError(fiotextBox, "Сотрудник с таким ФИО уже существует");
                return;
            }
            if (error ==2)
            {
                sotrphoneerrorProvider.SetError(phonetextBox, "Сотрудник с таким номером телефона уже существует");
                return;
            }
            else
            {
                MessageBox.Show("Выполнено успешно", "Добавление сотрудника");
                сотрудникTableAdapter.Fill(бД_автосалонаDataSet.Сотрудник);
            }

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (((сотрудникBindingSource.Filter != "") && (comboBox1.Text == ""))|| (сотрудникBindingSource.Filter == ""))
            {
                сотрудникBindingSource.Filter = "ФИО LIKE'" + searchfiotextBox.Text + "%'";
                сотрудникTableAdapter.Update(бД_автосалонаDataSet);
            }
            else
            {
                if (searchfiotextBox.Text == "")
                {
                    сотрудникBindingSource.Filter = "Должность ='" + comboBox1.Text + "'";
                    сотрудникTableAdapter.Update(бД_автосалонаDataSet);
                }
                else
                {
                    сотрудникBindingSource.Filter = сотрудникBindingSource.Filter + "AND ФИО LIKE'" + searchfiotextBox.Text + "%'";
                    сотрудникTableAdapter.Update(бД_автосалонаDataSet);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                сотрудникBindingSource.RemoveCurrent();
                this.Validate();
                this.сотрудникBindingSource.EndEdit();
                сотрудникTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch
            {
                this.сотрудникTableAdapter.Fill(this.бД_автосалонаDataSet.Сотрудник);
                MessageBox.Show("Попытка удаления связанного значения", "Удаление сотрудника");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникBindingSource.EndEdit();
            try
            {
                сотрудникTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обновление значений невозможно", "Изменение сотрудника");
                Console.WriteLine(ex);
                this.сотрудникTableAdapter.Fill(this.бД_автосалонаDataSet.Сотрудник);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                if (searchfiotextBox.Text == "")
                {
                    сотрудникBindingSource.Filter = "Должность ='" + comboBox1.Text + "'";
                    сотрудникTableAdapter.Update(бД_автосалонаDataSet);
                }
                else
                {
                    сотрудникBindingSource.Filter = сотрудникBindingSource.Filter+ "AND Должность ='" + comboBox1.Text + "'";
                    сотрудникTableAdapter.Update(бД_автосалонаDataSet);
                }
            }
            else
                if (searchfiotextBox.Text !="")
                {
                    сотрудникBindingSource.Filter = "ФИО LIKE'" + searchfiotextBox.Text + "%'";
                    сотрудникTableAdapter.Update(бД_автосалонаDataSet);
                }
                else
                {
                    сотрудникBindingSource.Filter = "";
                    сотрудникTableAdapter.Update(бД_автосалонаDataSet);
                }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.sellsByMonthTableAdapter.Fill(this.бД_автосалонаDataSet.SellsByMonth, dateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            this.sellsByMonthTableAdapter.Fill(this.бД_автосалонаDataSet.SellsByMonth, dateTimePicker1.Text);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            this.countOfDetailsNotInDealByNameTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfDetailsNotInDealByName);
            this.countOfCarsNotInDealByMarkTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfCarsNotInDealByMark);
        }
        private void UpdateOst(object sender, EventArgs e)
        {
            this.countOfDetailsNotInDealByNameTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfDetailsNotInDealByName);
            this.countOfCarsNotInDealByMarkTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfCarsNotInDealByMark);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (postnametextBox.Text == "")
            {
                postnameerrorProvider.SetError(postnametextBox,"Введите название");
                return;

            }
            if (postphonetextBox.Text == "")
            {
                postphoneerrorProvider.SetError(postphonetextBox, "Введите номер телефона");
                return;
       
            }
            int? error = 0;
            поставщикTableAdapter.InsertPost(postnametextBox.Text, postphonetextBox.Text, ref error);
            if(error==0)
            {
                MessageBox.Show("Выполнено успешно", "Добавление поставщика");
                this.поставщикTableAdapter.Fill(this.бД_автосалонаDataSet.Поставщик);
            }
            if(error==1)
            {
                postnameerrorProvider.SetError(postnametextBox, "Поставщик с таким названием уже существует");
            }
            if (error == 2)
            {
                postphoneerrorProvider.SetError(postphonetextBox, "Поставщик с таким номером телефона уже существует");
            }




        }

        private void postnametextBox_TextChanged(object sender, EventArgs e)
        {
            postnameerrorProvider.Clear();
        }

        private void postphonetextBox_TextChanged(object sender, EventArgs e)
        {
            postphoneerrorProvider.Clear();
        }

        private void countOfDetailsNotInDealByNameDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
