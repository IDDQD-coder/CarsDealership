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
    public partial class CreateDetail : Form
    {
        string position;
        public CreateDetail(string pos)
        {
            InitializeComponent();
            this.position = pos;
            this.Text = this.Text + " " + this.position;
            zaktextBox.Text = this.position;
            UpdateNum();
        }
        public void UpdateNum()
        {
            numtextBox.Text = Convert.ToString(допОборудованиеTableAdapter.FindMaxNum()+1);
        }
        public void CreateDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_автосалонаDataSet);

        }

        private void CreateDetail_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.DetailNotInDeal". При необходимости она может быть перемещена или удалена.
            this.detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.ManagersAndStorekeepers". При необходимости она может быть перемещена или удалена.
            this.managersAndStorekeepersTableAdapter.Fill(this.бД_автосалонаDataSet.ManagersAndStorekeepers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.ДопОборудование". При необходимости она может быть перемещена или удалена.
            this.допОборудованиеTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Managerslist". При необходимости она может быть перемещена или удалена.
            this.managerslistTableAdapter.Fill(this.бД_автосалонаDataSet.Managerslist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.бД_автосалонаDataSet.Поставщик);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f=true;
            if (numtextBox.Text == "") { numerrorProvider.SetError(numtextBox, "Введите номер детали"); f = false; }
            if (nametextBox.Text == "") {nameerrorProvider.SetError(nametextBox, "Введите название детали"); f = false; }
            if (postcomboBox.Text == "") {posterrorProvider.SetError(postcomboBox, "Выберите поставщика"); f = false; }
            if (!f) return;
            int? error = 0;
            допОборудованиеTableAdapter.InsertDetail(Convert.ToInt32(numtextBox.Text), nametextBox.Text, this.position, postcomboBox.Text, ref error);
            /*mysqlCommand.Parameters["@id"].Value = Convert.ToInt32(numtextBox.Text);
            mysqlCommand.Parameters["@name"].Value = nametextBox.Text;
            mysqlCommand.Parameters["@post"].Value = postcomboBox.Text;
            mysqlCommand.Parameters["@zak"].Value = zakComboBox.Text;

            mysqlConnection.Open();
            mysqlCommand.ExecuteNonQuery();
            mysqlConnection.Close();
            int res = (int)mysqlCommand.Parameters["@error"].Value;*/
            if (error == 0)
            {
                MessageBox.Show("Выполнено успешно","Добавление детали");
                допОборудованиеTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудование);
                detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
                UpdateNum();
            }
            if (error == 1) numerrorProvider.SetError(numtextBox, "Неуникальный номер");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            допОборудованиеBindingSource.Filter = "Название LIKE'" + searchtextBox.Text + "%'";
            //допОборудованиеTableAdapter.Update(бД_автосалонаDataSet);
            detailNotInDealBindingSource.Filter = "Название LIKE'" + searchtextBox.Text + "%'";
            //detailNotInDealTableAdapter.Adapter.Update(бД_автосалонаDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                допОборудованиеBindingSource.RemoveCurrent();
                this.Validate();
                this.допОборудованиеBindingSource.EndEdit();
                допОборудованиеTableAdapter.Update(бД_автосалонаDataSet);
                UpdateNum();
                detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
            }
            catch
            {
                MessageBox.Show("Попытка удалить связанное значение", "Удаление детали");
                this.допОборудованиеTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудование);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.допОборудованиеBindingSource.EndEdit();
            try
            {
                допОборудованиеTableAdapter.Update(бД_автосалонаDataSet);
                UpdateNum();
                detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обновление значений невозможно", "Изменение детали");
                Console.WriteLine(ex);
                this.допОборудованиеTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудование);
            }
        }

        private void numtextBox_TextChanged(object sender, EventArgs e)
        {
            numerrorProvider.Clear();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void допОборудованиеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void postcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
