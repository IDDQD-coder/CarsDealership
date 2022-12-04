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
    public partial class SalesmanHome : Form
    {
        string position;
        public SalesmanHome(string pos)
        {
            InitializeComponent();
            this.position = pos;
            this.Text = this.Text +" "+ this.position;
            sotrtextBox.Text = this.position;
        }
        public void SalesmanHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }
        private void SalesmanHome_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.ДопОборудованиеСделки". При необходимости она может быть перемещена или удалена.
            this.допОборудованиеСделкиTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудованиеСделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.ДопОборудование". При необходимости она может быть перемещена или удалена.
            this.допОборудованиеTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.DetailNotInDeal". При необходимости она может быть перемещена или удалена.
            this.detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.бД_автосалонаDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.CarsNotInDeal". При необходимости она может быть перемещена или удалена.
            this.carsNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.CarsNotInDeal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Сделка". При необходимости она может быть перемещена или удалена.
            this.сделкаTableAdapter.Fill(this.бД_автосалонаDataSet.Сделка);
           // this.detailsOfDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailsOfDeal,Convert.ToInt32(dealnumtextBox.Text));

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void сделкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сделкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_автосалонаDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vintextBox.Text == "")
            {
                vinerrorProvider.SetError(vintextBox, "Введите VIN");
                return;
            }
            if (vintextBox.TextLength < 17)
            {
                vinerrorProvider.SetError(vintextBox, "Минимальная длина VIN 17");
                return;
            }
            if (pricetextBox.Text == "")
            {
                priceerrorProvider.SetError(pricetextBox, "Введите сумму сделки");
                return;
            }
            int? error = 0;
            DateTime date = new DateTime();
            Console.WriteLine(date.Date);
            сделкаTableAdapter.InsertDeal(this.position, clienttextBox.Text, vintextBox.Text, DateTime.Now.Date, Convert.ToInt32(pricetextBox.Text), ref error);
            if (error == 0)
            {
                MessageBox.Show("Выполнено успешно!");
                сделкаTableAdapter.Fill(this.бД_автосалонаDataSet.Сделка);
            }
            if (error == 1)
            {
                vinerrorProvider.SetError(vintextBox, "Данный автомобиль уже в сделке или его не существует");
                return;
            }
            if (error == 3)
            {
                clientProvider.SetError(clienttextBox, "Не существует такого клиента");
            }
            if (error == 2)
            {
                priceerrorProvider.SetError(pricetextBox, "Сумма сделки меньше стоимости автомобиля");
            }
        }

        private void vintextBox_TextChanged(object sender, EventArgs e)
        {
            vinerrorProvider.Clear();
            decimal? price = 0;
            сделкаTableAdapter.PriceByVIN(vintextBox.Text, ref price);
            price=Convert.ToInt32(price);
            pricetextBox.Text = price.ToString();
        }

        private void pricetextBox_TextChanged(object sender, EventArgs e)
        {
            priceerrorProvider.Clear();
        }

        private void detailNotInDealDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void detailNotInDealDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detailnumtextBox1.Text = detailNotInDealDataGridView.CurrentRow.Cells[0].Value.ToString();
        }
        
        
        
        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            detailNotInDealBindingSource.Filter = "Название LIKE'" + searchtextBox.Text + "%'";
            detailNotInDealTableAdapter.Adapter.Update(бД_автосалонаDataSet);
        }

        private void searchfiotextBox_TextChanged(object sender, EventArgs e)
        {
            сделкаBindingSource.Filter = "ФиоКлиента LIKE'" + searchfiotextBox.Text + "%'";
            сделкаTableAdapter.Update(бД_автосалонаDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сделкаBindingSource.RemoveCurrent();
            this.Validate();
            this.сделкаBindingSource.EndEdit();
            сделкаTableAdapter.Update(бД_автосалонаDataSet);
            this.detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сделкаBindingSource.EndEdit();
            try
            {
                сделкаTableAdapter.Update(бД_автосалонаDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Обновление значений невозможно", "Обновление сделки");
                Console.WriteLine(ex);
                this.сделкаTableAdapter.Fill(this.бД_автосалонаDataSet.Сделка);
            }
        }

        private void clienttextBox_TextChanged(object sender, EventArgs e)
        {
            clientProvider.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine( сделкаDataGridView.CurrentRow.Cells[0].Value.ToString());
            if (dealnumtextBox.Text=="")
            {
                MessageBox.Show("Не выбрана сделка", "Ошибка добавления детали");
                return;
            }
            if(detailnumtextBox1.Text=="")
            {
                MessageBox.Show("Не выбрана деталь", "Ошибка добавления детали");
                return;
            }
            допОборудованиеСделкиTableAdapter.Insert(Convert.ToInt32(dealnumtextBox.Text), Convert.ToInt32(detailnumtextBox1.Text));
            this.detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
            this.detailsOfDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailsOfDeal, Convert.ToInt32(dealnumtextBox.Text));


        }

        private void сделкаDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void сделкаDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dealnumtextBox.Text = сделкаDataGridView.CurrentRow.Cells[0].Value.ToString();
            this.detailsOfDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailsOfDeal, Convert.ToInt32(dealnumtextBox.Text));
        }

        private void dealnumtextBox_TextChanged(object sender, EventArgs e)
        {
            if(dealnumtextBox.Text!="")
            {
                this.detailsOfDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailsOfDeal, Convert.ToInt32(dealnumtextBox.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new ConsultantFindCar();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new CreateClient();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int? detail_num = Convert.ToInt32(detailsOfDealDataGridView.CurrentRow.Cells[0].Value.ToString());
            this.допОборудованиеСделкиTableAdapter.DeleteDetailFromDeal(detail_num);
            this.detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);
            this.detailsOfDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailsOfDeal, Convert.ToInt32(dealnumtextBox.Text));
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}