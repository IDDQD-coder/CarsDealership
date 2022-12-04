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
    public partial class StorekeeperHome : Form
    {
        public StorekeeperHome()
        {
            InitializeComponent();
        }
        public void StorekeeperHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms[0];
            frm.Show();
        }
        private void StorekeeperHome_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.бД_автосалонаDataSet.Клиент);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Form frm = new CreateDetail();
            //frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new ConsultantFindCar();
            frm.Show();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.бД_автосалонаDataSet);

        }
    }
}
