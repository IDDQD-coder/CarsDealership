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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.бД_автосалонаDataSet.Сотрудник);
            this.сотрудникBindingSource.Filter = "Должность='Продавец'";
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Managerslist". При необходимости она может быть перемещена или удалена.
            this.managerslistTableAdapter.Fill(this.бД_автосалонаDataSet.Managerslist);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Менеджер")
            {
                managerslistComboBox.Visible = true;
            }
            else managerslistComboBox.Visible = false;
            if (comboBox1.Text == "Продавец")
            {
                salesmanComboBox.Visible = true;
            }
            else salesmanComboBox.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string val = comboBox1.Text;
            switch (val)
            {
                case "":
                    Console.WriteLine("Введите роль");
                    break;
                case "Менеджер":
                    this.Hide();
                    Form ManagerHome = new ManagerHome(managerslistComboBox.Text);
                    ManagerHome.Show();
                    break;
                case "Продавец":
                    this.Hide();
                    Form SalesmanHome = new SalesmanHome(salesmanComboBox.Text);
                    SalesmanHome.Show();
                    break;
                case "Консультант":
                    this.Hide();
                    Form ConsultantHome = new ConsultantHome();
                    ConsultantHome.Show();
                    break;
                case "Механик":
                    this.Hide();
                    Form MechanicEquipment = new MechanicEquipment();
                    MechanicEquipment.Show();
                    break;
                case "Кладовщик":
                    this.Hide();
                    Form StorekeeperHome = new StorekeeperHome();
                    StorekeeperHome.Show();
                    break;
            }
        }
    }
}
