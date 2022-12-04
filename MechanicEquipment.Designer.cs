
namespace CarsDB
{
    partial class MechanicEquipment
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
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dealradioButton = new System.Windows.Forms.RadioButton();
            this.autoradioButton = new System.Windows.Forms.RadioButton();
            this.carEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.carEquipmentTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.CarEquipmentTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.carEquipmentByCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carEquipmentByCarTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.CarEquipmentByCarTableAdapter();
            this.допОборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.допОборудованиеTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ДопОборудованиеTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradientPanel2 = new CarsDB.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.carEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carEquipmentByCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(24, 115);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(389, 22);
            this.searchtextBox.TabIndex = 1;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // dealradioButton
            // 
            this.dealradioButton.AutoSize = true;
            this.dealradioButton.Checked = true;
            this.dealradioButton.Location = new System.Drawing.Point(24, 45);
            this.dealradioButton.Name = "dealradioButton";
            this.dealradioButton.Size = new System.Drawing.Size(149, 21);
            this.dealradioButton.TabIndex = 2;
            this.dealradioButton.TabStop = true;
            this.dealradioButton.Text = "По номеру сделки";
            this.dealradioButton.UseVisualStyleBackColor = true;
            this.dealradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // autoradioButton
            // 
            this.autoradioButton.AutoSize = true;
            this.autoradioButton.Location = new System.Drawing.Point(24, 72);
            this.autoradioButton.Name = "autoradioButton";
            this.autoradioButton.Size = new System.Drawing.Size(159, 21);
            this.autoradioButton.TabIndex = 3;
            this.autoradioButton.Text = "По VIN номеру авто";
            this.autoradioButton.UseVisualStyleBackColor = true;
            this.autoradioButton.CheckedChanged += new System.EventHandler(this.autoradioButton_CheckedChanged);
            // 
            // carEquipmentBindingSource
            // 
            this.carEquipmentBindingSource.DataMember = "CarEquipment";
            this.carEquipmentBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carEquipmentTableAdapter
            // 
            this.carEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеСделкиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.СделкаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТестДрайвTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.autoradioButton);
            this.groupBox1.Controls.Add(this.searchtextBox);
            this.groupBox1.Controls.Add(this.dealradioButton);
            this.groupBox1.Location = new System.Drawing.Point(86, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск деталей";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(147, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carEquipmentByCarBindingSource
            // 
            this.carEquipmentByCarBindingSource.DataMember = "CarEquipmentByCar";
            this.carEquipmentByCarBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // carEquipmentByCarTableAdapter
            // 
            this.carEquipmentByCarTableAdapter.ClearBeforeFill = true;
            // 
            // допОборудованиеBindingSource
            // 
            this.допОборудованиеBindingSource.DataMember = "ДопОборудование";
            this.допОборудованиеBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // допОборудованиеTableAdapter
            // 
            this.допОборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 339);
            this.dataGridView1.TabIndex = 4;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.AutoSize = true;
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.gradientPanel2.ColorFillSecond = System.Drawing.Color.Cyan;
            this.gradientPanel2.Controls.Add(this.dataGridView1);
            this.gradientPanel2.Controls.Add(this.groupBox1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(898, 621);
            this.gradientPanel2.TabIndex = 18;
            // 
            // MechanicEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 621);
            this.Controls.Add(this.gradientPanel2);
            this.MaximizeBox = false;
            this.Name = "MechanicEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Домашняя страница: Механик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MechanicEquipment_FormClosed);
            this.Load += new System.EventHandler(this.MechanicEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carEquipmentByCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource carEquipmentBindingSource;
        private БД_автосалонаDataSetTableAdapters.CarEquipmentTableAdapter carEquipmentTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.RadioButton dealradioButton;
        private System.Windows.Forms.RadioButton autoradioButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource carEquipmentByCarBindingSource;
        private БД_автосалонаDataSetTableAdapters.CarEquipmentByCarTableAdapter carEquipmentByCarTableAdapter;
        private System.Windows.Forms.BindingSource допОборудованиеBindingSource;
        private БД_автосалонаDataSetTableAdapters.ДопОборудованиеTableAdapter допОборудованиеTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GradientPanel gradientPanel2;
    }
}