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
    public partial class ConsultantFindCar : Form
    {
        public ConsultantFindCar()
        {
            InitializeComponent();
        }
        public void ConsultantFindCar_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void ConsultantFindCar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.CarsNotInDeal". При необходимости она может быть перемещена или удалена.
            this.carsNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.CarsNotInDeal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.MarksNotInDeal". При необходимости она может быть перемещена или удалена.
            this.marksNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.MarksNotInDeal);

        }
        private void FindCar(object sender, EventArgs e)
        {
            string filter="";
            bool marker = false;
            if (marktextBox.Text!="")
            {
                filter = filter + "Марка LIKE'" + marktextBox.Text + "%' ";
                marker = true;
            }
            if (modeltextBox.Text!="")
            {
                if (marker) filter = filter+" AND ";
                filter = filter + "Модель LIKE'" + modeltextBox.Text + "%' ";
                marker = true;
            }
            if (yeartextBox.Text !="")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "ГодВыпуска ='" + yeartextBox.Text + "' ";
                marker = true;
            }
            if (typecomboBox.Text != "")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "ТипКузова ='" + typecomboBox.Text + "' ";
                marker = true;
            }
            if (colorcomboBox.Text != "")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "Цвет ='" + colorcomboBox.Text + "' ";
                marker = true;
            }
            if(matherialcomboBox.Text!="")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "МатериалСалона ='" + matherialcomboBox.Text + "' ";
                marker = true;
            }
            if (kppcomboBox.Text != "")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "КоробкаПередач ='" + kppcomboBox.Text + "' ";
                marker = true;
            }
            if (enginecomboBox.Text != "")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "ТипДвигателя ='" + enginecomboBox.Text + "' ";
                marker = true;
            }
            if (powerTextBox.Text != "")
            {
                if (marker) filter = filter + " AND ";
                filter = filter + "Мощность ='" + powerTextBox.Text + "' ";
                marker = true;
            }
            if (marker) filter = filter + " AND ";
            filter = filter + "Стоимость <= " + Convert.ToString(pricetrackBar.Value * 1000000)+" ";
            Console.WriteLine(filter);
            carsNotInDealBindingSource.Filter = filter;

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void автомобильBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void маркаComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FindCar(sender, e);
        }



        private void modelsByMarkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void автомобильDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.автомобильTableAdapter.FillBy1(this.бД_автосалонаDataSet.Автомобиль);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        


        private void годВыпускаTextBox_TextChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void pricetrackBar_Scroll(object sender, EventArgs e)
        {
            pricelabel.Text = "Текущая цена " + Convert.ToString(pricetrackBar.Value) + " млн.";
            FindCar(sender, e);
        }

        private void marktextBox_TextChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void modeltextBox_TextChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void yeartextBox_TextChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void enginecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void matherialcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindCar(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pricelabel_Click(object sender, EventArgs e)
        {

        }

        private void pricetrackBar_Scroll_1(object sender, EventArgs e)
        {

        }
    }
}
