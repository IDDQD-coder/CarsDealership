
namespace CarsDB
{
    partial class ConsultantFindCar
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
            this.автомобильBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.автомобильTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.АвтомобильTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.сделкаTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.СделкаTableAdapter();
            this.тестДрайвTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ТестДрайвTableAdapter();
            this.marksNotInDealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksNotInDealTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.MarksNotInDealTableAdapter();
            this.modelsByMarkTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ModelsByMarkTableAdapter();
            this.modelsByMarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.КлиентTableAdapter();
            this.carsNotInDealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsNotInDealTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.CarsNotInDealTableAdapter();
            this.gradientPanel2 = new CarsDB.GradientPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetrackBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.modeltextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.marktextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.yeartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.matherialcomboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kppcomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.enginecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorcomboBox = new System.Windows.Forms.ComboBox();
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.carsNotInDealDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksNotInDealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsByMarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsNotInDealBindingSource)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricetrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsNotInDealDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // автомобильBindingSource
            // 
            this.автомобильBindingSource.DataMember = "Автомобиль";
            this.автомобильBindingSource.DataSource = this.бД_автосалонаDataSet;
            this.автомобильBindingSource.CurrentChanged += new System.EventHandler(this.автомобильBindingSource_CurrentChanged);
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // автомобильTableAdapter
            // 
            this.автомобильTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = this.автомобильTableAdapter;
            this.tableAdapterManager.ДопОборудованиеTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеСделкиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.СделкаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТестДрайвTableAdapter = null;
            // 
            // сделкаTableAdapter
            // 
            this.сделкаTableAdapter.ClearBeforeFill = true;
            // 
            // тестДрайвTableAdapter
            // 
            this.тестДрайвTableAdapter.ClearBeforeFill = true;
            // 
            // marksNotInDealBindingSource
            // 
            this.marksNotInDealBindingSource.DataMember = "MarksNotInDeal";
            this.marksNotInDealBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // marksNotInDealTableAdapter
            // 
            this.marksNotInDealTableAdapter.ClearBeforeFill = true;
            // 
            // modelsByMarkTableAdapter
            // 
            this.modelsByMarkTableAdapter.ClearBeforeFill = true;
            // 
            // modelsByMarkBindingSource
            // 
            this.modelsByMarkBindingSource.DataMember = "ModelsByMark";
            this.modelsByMarkBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // carsNotInDealBindingSource
            // 
            this.carsNotInDealBindingSource.DataMember = "CarsNotInDeal";
            this.carsNotInDealBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // carsNotInDealTableAdapter
            // 
            this.carsNotInDealTableAdapter.ClearBeforeFill = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.gradientPanel2.ColorFillSecond = System.Drawing.Color.Cyan;
            this.gradientPanel2.Controls.Add(this.groupBox1);
            this.gradientPanel2.Controls.Add(this.carsNotInDealDataGridView);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1924, 1033);
            this.gradientPanel2.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pricelabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pricetrackBar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.modeltextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.marktextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.yeartextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.powerTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.matherialcomboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.kppcomboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.enginecomboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colorcomboBox);
            this.groupBox1.Controls.Add(this.typecomboBox);
            this.groupBox1.Location = new System.Drawing.Point(31, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 694);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Селектор подбора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(136, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Марка:";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pricelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pricelabel.Location = new System.Drawing.Point(273, 575);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(155, 17);
            this.pricelabel.TabIndex = 32;
            this.pricelabel.Text = "Текущая цена 25 млн.";
            this.pricelabel.Click += new System.EventHandler(this.pricelabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Коробка передач:";
            // 
            // pricetrackBar
            // 
            this.pricetrackBar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pricetrackBar.Location = new System.Drawing.Point(214, 536);
            this.pricetrackBar.Maximum = 25;
            this.pricetrackBar.Name = "pricetrackBar";
            this.pricetrackBar.Size = new System.Drawing.Size(261, 56);
            this.pricetrackBar.TabIndex = 31;
            this.pricetrackBar.Value = 25;
            this.pricetrackBar.Scroll += new System.EventHandler(this.pricetrackBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(59, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Тип двигателя:";
            // 
            // modeltextBox
            // 
            this.modeltextBox.Location = new System.Drawing.Point(253, 162);
            this.modeltextBox.Name = "modeltextBox";
            this.modeltextBox.Size = new System.Drawing.Size(160, 22);
            this.modeltextBox.TabIndex = 30;
            this.modeltextBox.TextChanged += new System.EventHandler(this.modeltextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(93, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Тип кузова:";
            // 
            // marktextBox
            // 
            this.marktextBox.Location = new System.Drawing.Point(253, 111);
            this.marktextBox.Name = "marktextBox";
            this.marktextBox.Size = new System.Drawing.Size(160, 22);
            this.marktextBox.TabIndex = 29;
            this.marktextBox.TextChanged += new System.EventHandler(this.marktextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(148, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Цвет:";
            // 
            // yeartextBox
            // 
            this.yeartextBox.Location = new System.Drawing.Point(253, 208);
            this.yeartextBox.Name = "yeartextBox";
            this.yeartextBox.Size = new System.Drawing.Size(160, 22);
            this.yeartextBox.TabIndex = 26;
            this.yeartextBox.TextChanged += new System.EventHandler(this.yeartextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Год выпуска:";
            // 
            // powerTextBox
            // 
            this.powerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.автомобильBindingSource, "ГодВыпуска", true));
            this.powerTextBox.Location = new System.Drawing.Point(253, 480);
            this.powerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(160, 22);
            this.powerTextBox.TabIndex = 24;
            this.powerTextBox.TextChanged += new System.EventHandler(this.modeltextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(99, 480);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Мощность:";
            // 
            // matherialcomboBox
            // 
            this.matherialcomboBox.FormattingEnabled = true;
            this.matherialcomboBox.Items.AddRange(new object[] {
            "",
            "Кожанный",
            "Тряпичный"});
            this.matherialcomboBox.Location = new System.Drawing.Point(253, 346);
            this.matherialcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.matherialcomboBox.Name = "matherialcomboBox";
            this.matherialcomboBox.Size = new System.Drawing.Size(160, 24);
            this.matherialcomboBox.TabIndex = 0;
            this.matherialcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(92, 547);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Стоимость:";
            // 
            // kppcomboBox
            // 
            this.kppcomboBox.FormattingEnabled = true;
            this.kppcomboBox.Items.AddRange(new object[] {
            "",
            "Автоматическая",
            "Механическая"});
            this.kppcomboBox.Location = new System.Drawing.Point(253, 389);
            this.kppcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.kppcomboBox.Name = "kppcomboBox";
            this.kppcomboBox.Size = new System.Drawing.Size(160, 24);
            this.kppcomboBox.TabIndex = 0;
            this.kppcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(36, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Материал салона:";
            // 
            // enginecomboBox
            // 
            this.enginecomboBox.FormattingEnabled = true;
            this.enginecomboBox.Items.AddRange(new object[] {
            "",
            "Электрический",
            "Бензиновый",
            "Дизельный"});
            this.enginecomboBox.Location = new System.Drawing.Point(253, 435);
            this.enginecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.enginecomboBox.Name = "enginecomboBox";
            this.enginecomboBox.Size = new System.Drawing.Size(160, 24);
            this.enginecomboBox.TabIndex = 0;
            this.enginecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(121, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Модель:";
            // 
            // colorcomboBox
            // 
            this.colorcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.автомобильBindingSource, "Цвет", true));
            this.colorcomboBox.FormattingEnabled = true;
            this.colorcomboBox.Items.AddRange(new object[] {
            "",
            "Черный",
            "Белый",
            "Красный",
            "Оранженый",
            "Желтый",
            "Зеленый",
            "Голубой ",
            "Синий",
            "Фиолетовый"});
            this.colorcomboBox.Location = new System.Drawing.Point(253, 298);
            this.colorcomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorcomboBox.Name = "colorcomboBox";
            this.colorcomboBox.Size = new System.Drawing.Size(160, 24);
            this.colorcomboBox.TabIndex = 0;
            this.colorcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // typecomboBox
            // 
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.Items.AddRange(new object[] {
            "",
            "Седан",
            "Кроссовер",
            "Хэтчбек",
            "Купе",
            "Универсал"});
            this.typecomboBox.Location = new System.Drawing.Point(253, 253);
            this.typecomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(160, 24);
            this.typecomboBox.TabIndex = 0;
            this.typecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // carsNotInDealDataGridView
            // 
            this.carsNotInDealDataGridView.AutoGenerateColumns = false;
            this.carsNotInDealDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.carsNotInDealDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsNotInDealDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.carsNotInDealDataGridView.DataSource = this.carsNotInDealBindingSource;
            this.carsNotInDealDataGridView.Location = new System.Drawing.Point(586, 52);
            this.carsNotInDealDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.carsNotInDealDataGridView.Name = "carsNotInDealDataGridView";
            this.carsNotInDealDataGridView.RowHeadersWidth = 51;
            this.carsNotInDealDataGridView.Size = new System.Drawing.Size(1329, 759);
            this.carsNotInDealDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "VIN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn2.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Марка";
            this.dataGridViewTextBoxColumn4.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 79;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Модель";
            this.dataGridViewTextBoxColumn5.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 87;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ГодВыпуска";
            this.dataGridViewTextBoxColumn6.HeaderText = "ГодВыпуска";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 117;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ТипКузова";
            this.dataGridViewTextBoxColumn7.HeaderText = "ТипКузова";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 108;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Цвет";
            this.dataGridViewTextBoxColumn8.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "МатериалСалона";
            this.dataGridViewTextBoxColumn9.HeaderText = "МатериалСалона";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 152;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "КоробкаПередач";
            this.dataGridViewTextBoxColumn10.HeaderText = "КоробкаПередач";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 151;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ТипДвигателя";
            this.dataGridViewTextBoxColumn11.HeaderText = "ТипДвигателя";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 132;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Мощность";
            this.dataGridViewTextBoxColumn12.HeaderText = "Мощность";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 104;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn13.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 107;
            // 
            // ConsultantFindCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultantFindCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подбор автомобиля";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultantFindCar_FormClosed);
            this.Load += new System.EventHandler(this.ConsultantFindCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.автомобильBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksNotInDealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsByMarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsNotInDealBindingSource)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pricetrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsNotInDealDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource автомобильBindingSource;
        private БД_автосалонаDataSetTableAdapters.АвтомобильTableAdapter автомобильTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private БД_автосалонаDataSetTableAdapters.СделкаTableAdapter сделкаTableAdapter;
        private БД_автосалонаDataSetTableAdapters.ТестДрайвTableAdapter тестДрайвTableAdapter;
        private System.Windows.Forms.BindingSource marksNotInDealBindingSource;
        private БД_автосалонаDataSetTableAdapters.MarksNotInDealTableAdapter marksNotInDealTableAdapter;
        private БД_автосалонаDataSetTableAdapters.ModelsByMarkTableAdapter modelsByMarkTableAdapter;
        private System.Windows.Forms.BindingSource modelsByMarkBindingSource;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private БД_автосалонаDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.BindingSource carsNotInDealBindingSource;
        private БД_автосалонаDataSetTableAdapters.CarsNotInDealTableAdapter carsNotInDealTableAdapter;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar pricetrackBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modeltextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox marktextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox matherialcomboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox kppcomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox enginecomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox colorcomboBox;
        private System.Windows.Forms.ComboBox typecomboBox;
        private System.Windows.Forms.DataGridView carsNotInDealDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}