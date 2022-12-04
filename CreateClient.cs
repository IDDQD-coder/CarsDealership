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
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();

        }
        public void CreateClient_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_автосалонаDataSet);

        }

        private void CreateClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.бД_автосалонаDataSet.Клиент);

        }

        private void фИОTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
     
        private void номерТелефонаTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }
        private void паспортныеДанныеTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void фИОLabel_Click(object sender, EventArgs e)
        {

        }

        private void номерТелефонаLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text == "")
                клиентBindingSource.Filter = "ФИО LIKE'" + textBox1.Text + "%'";
            if (textBox1.Text == "" && textBox2.Text != "")
                клиентBindingSource.Filter = "НомерТелефона LIKE'" + textBox2.Text + "%'";
            if (textBox1.Text != "" && textBox2.Text != "")
                клиентBindingSource.Filter = "НомерТелефона LIKE'" + textBox2.Text + "%' AND ФИО LIKE'" + textBox1.Text + "%'";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if((клиентBindingSource.Filter=="")||(textBox2.Text==""))
                клиентBindingSource.Filter = "ФИО LIKE'" + textBox1.Text + "%'";
            else
                клиентBindingSource.Filter = "НомерТелефона LIKE'" + textBox2.Text + "%' AND ФИО LIKE'" + textBox1.Text + "%'";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if ((клиентBindingSource.Filter == "") || (textBox1.Text == ""))
                клиентBindingSource.Filter = "НомерТелефона LIKE'" + textBox2.Text + "%'";
            else
                клиентBindingSource.Filter = "НомерТелефона LIKE'" + textBox2.Text + "%' AND ФИО LIKE'" + textBox1.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (фИОTextBox.Text == "") { errorProvider1.SetError(фИОTextBox, "Введите ФИО"); return; }
            if (номерТелефонаTextBox.Text == "") { errorProvider2.SetError(номерТелефонаTextBox, "Введите номер телефона"); return; }
            if (паспортныеДанныеTextBox.Text == ""){ errorProvider3.SetError(паспортныеДанныеTextBox, "Введите паспортные данные"); return;}
            int? error = 0;
            клиентTableAdapter.InsertClient(фИОTextBox.Text, номерТелефонаTextBox.Text, паспортныеДанныеTextBox.Text, ref error);
            if (error == 0)
            {
                MessageBox.Show("Выполнено успешно", "Добавление клиента");
                номерТелефонаTextBox.Text = "";
                фИОTextBox.Text = "";
                паспортныеДанныеTextBox.Text = "";
                this.клиентTableAdapter.Fill(this.бД_автосалонаDataSet.Клиент);
            }
            if(error==1)
            {
                errorProvider1.SetError(фИОTextBox, "Существует клиент с таким ФИО");
            }
            if (error == 2)
            {
                errorProvider2.SetError(номерТелефонаTextBox, "Существует клиент с таким номером телефона");
            }
            if (error == 3)
            {
                errorProvider3.SetError(паспортныеДанныеTextBox, "Существует клиент с такими паспортными данными");
            }
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
