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
    public partial class ConsultantHome : Form
    {
        public ConsultantHome()
        {
            InitializeComponent();
        }
        public void ConsultantHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ConsultantFindCar = new ConsultantFindCar();
            ConsultantFindCar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form TestDriveForm = new TestDriveForm();
            TestDriveForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form CreateClient = new CreateClient();
            CreateClient.Show();
        }

        private void ConsultantHome_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new FindDetail();
            frm.Show();
        }
    }
}
