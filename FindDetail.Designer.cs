
namespace CarsDB
{
    partial class FindDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.detailNotInDealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailNotInDealTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.DetailNotInDealTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.поставщикTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ПоставщикTableAdapter();
            this.detailNotInDealDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradientPanel2 = new CarsDB.GradientPanel();
            this.posttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.countOfDetailsNotInDealByNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countOfDetailsNotInDealByNameTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.CountOfDetailsNotInDealByNameTableAdapter();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNotInDealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNotInDealDataGridView)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countOfDetailsNotInDealByNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailNotInDealBindingSource
            // 
            this.detailNotInDealBindingSource.DataMember = "DetailNotInDeal";
            this.detailNotInDealBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // detailNotInDealTableAdapter
            // 
            this.detailNotInDealTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеСделкиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
            this.tableAdapterManager.СделкаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТестДрайвTableAdapter = null;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // detailNotInDealDataGridView
            // 
            this.detailNotInDealDataGridView.AutoGenerateColumns = false;
            this.detailNotInDealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailNotInDealDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.detailNotInDealDataGridView.DataSource = this.detailNotInDealBindingSource;
            this.detailNotInDealDataGridView.Location = new System.Drawing.Point(83, 37);
            this.detailNotInDealDataGridView.Name = "detailNotInDealDataGridView";
            this.detailNotInDealDataGridView.RowHeadersWidth = 51;
            this.detailNotInDealDataGridView.RowTemplate.Height = 24;
            this.detailNotInDealDataGridView.Size = new System.Drawing.Size(556, 321);
            this.detailNotInDealDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НомерДетали";
            this.dataGridViewTextBoxColumn1.HeaderText = "НомерДетали";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 101;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Закупщик";
            this.dataGridViewTextBoxColumn3.HeaderText = "Закупщик";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn4.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.AutoSize = true;
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.gradientPanel2.ColorFillSecond = System.Drawing.Color.Cyan;
            this.gradientPanel2.Controls.Add(this.posttextBox);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.nameComboBox);
            this.gradientPanel2.Controls.Add(this.detailNotInDealDataGridView);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(804, 508);
            this.gradientPanel2.TabIndex = 18;
            this.gradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel2_Paint);
            // 
            // posttextBox
            // 
            this.posttextBox.Location = new System.Drawing.Point(394, 425);
            this.posttextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.posttextBox.MaxLength = 17;
            this.posttextBox.Name = "posttextBox";
            this.posttextBox.Size = new System.Drawing.Size(245, 22);
            this.posttextBox.TabIndex = 11;
            this.posttextBox.TextChanged += new System.EventHandler(this.posttextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 11F);
            this.label1.Location = new System.Drawing.Point(274, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Поставщик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 11F);
            this.label2.Location = new System.Drawing.Point(217, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название детали";
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataSource = this.countOfDetailsNotInDealByNameBindingSource;
            this.nameComboBox.DisplayMember = "Название";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(394, 376);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(245, 24);
            this.nameComboBox.TabIndex = 1;
            this.nameComboBox.ValueMember = "Название";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // countOfDetailsNotInDealByNameBindingSource
            // 
            this.countOfDetailsNotInDealByNameBindingSource.DataMember = "CountOfDetailsNotInDealByName";
            this.countOfDetailsNotInDealByNameBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // countOfDetailsNotInDealByNameTableAdapter
            // 
            this.countOfDetailsNotInDealByNameTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // FindDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 508);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FindDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подбор деталей";
            this.Load += new System.EventHandler(this.FindDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNotInDealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNotInDealDataGridView)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countOfDetailsNotInDealByNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource detailNotInDealBindingSource;
        private БД_автосалонаDataSetTableAdapters.DetailNotInDealTableAdapter detailNotInDealTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView detailNotInDealDataGridView;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.BindingSource countOfDetailsNotInDealByNameBindingSource;
        private БД_автосалонаDataSetTableAdapters.CountOfDetailsNotInDealByNameTableAdapter countOfDetailsNotInDealByNameTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private БД_автосалонаDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private System.Windows.Forms.TextBox posttextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}