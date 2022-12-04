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
    public partial class FindDetail : Form
    {
        public FindDetail()
        {
            InitializeComponent();
            detailNotInDealBindingSource.Filter = "Название= '" + nameComboBox.Text + "'";
            detailNotInDealTableAdapter.Adapter.Update(бД_автосалонаDataSet.DetailNotInDeal);
        }

        private void FindDetail_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.бД_автосалонаDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.CountOfDetailsNotInDealByName". При необходимости она может быть перемещена или удалена.
            this.countOfDetailsNotInDealByNameTableAdapter.Fill(this.бД_автосалонаDataSet.CountOfDetailsNotInDealByName);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_автосалонаDataSet.DetailNotInDeal". При необходимости она может быть перемещена или удалена.
            this.detailNotInDealTableAdapter.Fill(this.бД_автосалонаDataSet.DetailNotInDeal);

        }

        private void clienttextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void postComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (posttextBox.Text == "")
            {
                detailNotInDealBindingSource.Filter = "Название= '" + nameComboBox.Text + "'";
                detailNotInDealTableAdapter.Adapter.Update(бД_автосалонаDataSet.DetailNotInDeal);
            }
            else
            {
                detailNotInDealBindingSource.Filter = "Название= '" + nameComboBox.Text + "' AND Поставщик LIKE'" + posttextBox.Text + "%'";
                detailNotInDealTableAdapter.Adapter.Update(бД_автосалонаDataSet.DetailNotInDeal);

            }
        }

        private void posttextBox_TextChanged(object sender, EventArgs e)
        {
            detailNotInDealBindingSource.Filter = "Название= '" + nameComboBox.Text + "' AND Поставщик LIKE'" + posttextBox.Text + "%'";
            detailNotInDealTableAdapter.Adapter.Update(бД_автосалонаDataSet.DetailNotInDeal);
        }
    }
}
