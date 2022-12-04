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
    public partial class MechanicEquipment : Form
    {
        public MechanicEquipment()
        {
            InitializeComponent();
            
        }
        public void MechanicEquipment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchtextBox.MaxLength = 32767;
        }

        private void autoradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchtextBox.MaxLength = 17;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (searchtextBox.Text == "")
            {
                errorProvider1.SetError(searchtextBox, "Введите данные");
                return;
            }
            if (dealradioButton.Checked)
            {
                dataGridView1.DataSource = carEquipmentBindingSource;
                carEquipmentTableAdapter.Fill(this.бД_автосалонаDataSet.CarEquipment, Convert.ToInt32(searchtextBox.Text));
            }
            else
            {
                if (searchtextBox.Text.Length < 17) errorProvider1.SetError(searchtextBox, "Введите корректный VIN");
                dataGridView1.DataSource = carEquipmentByCarBindingSource;
                carEquipmentByCarTableAdapter.Fill(this.бД_автосалонаDataSet.CarEquipmentByCar, searchtextBox.Text);
            }

        }

        private void MechanicEquipment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.ДопОборудование". При необходимости она может быть перемещена или удалена.
            this.допОборудованиеTableAdapter.Fill(this.бД_автосалонаDataSet.ДопОборудование);

        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
