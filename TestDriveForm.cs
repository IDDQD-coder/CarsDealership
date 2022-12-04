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
    public partial class TestDriveForm : Form
    {
        public TestDriveForm()
        {
            InitializeComponent(); 
            datedateTimePicker1.MinDate = DateTime.Today;
            this.тестДрайвTableAdapter.Fill(this.бД_автосалонаDataSet.ТестДрайв);
            тестДрайвBindingSource.Filter = "Дата ='" + datedateTimePicker1.Value.Date + "'";
        }
        public void TestDriveForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        public void UpdateTable(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                тестДрайвBindingSource.Filter = "ФиоКлиента LIKE'" + searchfiotextBox.Text + "%'";
               
            }
            else
            {
                тестДрайвBindingSource.Filter = "ФиоКлиента LIKE'" + searchfiotextBox.Text + "%' AND Дата='" + datedateTimePicker1.Value.Date + "'";
                
            }

        }

        private void тестДрайвBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тестДрайвBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_автосалонаDataSet);

        }

        private void TestDriveForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form CreateClient = new CreateClient();
            CreateClient.Show();
        }

        private void времяTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void времяLabel_Click(object sender, EventArgs e)
        {

        }

        private void времяDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void времяLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (datedateTimePicker1.Text != "" && timedateTimePicker2.Text != "" && vintextBox1.Text != "" && fiotextBox1.Text != "")
            {
                int? error = 0;
                string stime = timedateTimePicker2.Value.TimeOfDay.ToString();
                Console.WriteLine(stime);
                stime = stime.Substring(stime.Length-2, 3);
                Console.WriteLine(stime);
                DateTime time = Convert.ToDateTime(stime);
                Console.WriteLine(stime);
                тестДрайвTableAdapter.InsertTestDrive(datedateTimePicker1.Value, time.TimeOfDay, vintextBox1.Text, fiotextBox1.Text,ref error);
                if (error == 0) { MessageBox.Show("Успешно добавлено","Добавление записи"); return; }
                if (error == 1) {fioerrorProvider.SetError(fiotextBox1, "Такого клиента не существует"); return; }
                if (error == 2) {vinerrorProvider.SetError(vintextBox1, "Автомобиль с таким VIN недоступен"); return;}
                if (error == 3) {timeerrorProvider.SetError(timedateTimePicker2, "Это время занято");return; }
}
            else
            {
               if (datedateTimePicker1.Text == "") {dateerrorProvider.SetError(datedateTimePicker1, "Выберите дату"); return; }
                if (timedateTimePicker2.Text == "") {timeerrorProvider.SetError(timedateTimePicker2, "Выберите время"); return; }
                if (vintextBox1.TextLength< 17) {vinerrorProvider.SetError(vintextBox1, "Введите корректный VIN"); return; }
                if (fiotextBox1.Text == "") {fioerrorProvider.SetError(fiotextBox1, "Введите ФИО"); return; }
            }
            UpdateTable(sender, e);
            тестДрайвTableAdapter.Fill(this.бД_автосалонаDataSet.ТестДрайв);
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(datedateTimePicker1.Value.Date);
            UpdateTable(sender, e);
        }

        private void vinTextBox_TextChanged(object sender, EventArgs e)
        {
            vinerrorProvider.Clear();
        }

        private void fioTextBox_TextChanged(object sender, EventArgs e)
        {
            fioerrorProvider.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new ConsultantFindCar();
            frm.Show();
        }

        private void searchfiotextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTable(sender, e);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            тестДрайвBindingSource.RemoveCurrent();
            this.Validate();
            this.тестДрайвBindingSource.EndEdit();
            тестДрайвTableAdapter.Update(бД_автосалонаDataSet);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable(sender, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(timedateTimePicker2.Value.TimeOfDay.ToString());
            timeerrorProvider.Clear();
        }

        private void datedateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTable(sender,e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тестДрайвBindingSource.EndEdit();
            try
            {
                тестДрайвTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обновление значений невозможно", "ERROOR");
                Console.WriteLine(ex);
                this.тестДрайвTableAdapter.Fill(this.бД_автосалонаDataSet.ТестДрайв);
            }
        }

        private void vintextBox1_TextChanged(object sender, EventArgs e)
        {
            vinerrorProvider.Clear();
        }

        private void fiotextBox1_TextChanged(object sender, EventArgs e)
        {
            fioerrorProvider.Clear();
        }
    }
}
