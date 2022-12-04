
namespace CarsDB
{
    partial class CreateDetail
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
            this.button1 = new System.Windows.Forms.Button();
            this.numtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mysqlCommand = new System.Data.SqlClient.SqlCommand();
            this.mysqlConnection = new System.Data.SqlClient.SqlConnection();
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ПоставщикTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.managerslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerslistTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ManagerslistTableAdapter();
            this.numerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.zakerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.posterrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.допОборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.допОборудованиеTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ДопОборудованиеTableAdapter();
            this.допОборудованиеDataGridView = new System.Windows.Forms.DataGridView();
            this.номерДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закупщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailNotInDealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gradientPanel1 = new CarsDB.GradientPanel();
            this.zaktextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.допОборудованиеDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcomboBox = new System.Windows.Forms.ComboBox();
            this.managersAndStorekeepersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managersAndStorekeepersTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ManagersAndStorekeepersTableAdapter();
            this.detailNotInDealTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.DetailNotInDealTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNotInDealBindingSource)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersAndStorekeepersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(64, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numtextBox
            // 
            this.numtextBox.Location = new System.Drawing.Point(39, 55);
            this.numtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numtextBox.Name = "numtextBox";
            this.numtextBox.ReadOnly = true;
            this.numtextBox.Size = new System.Drawing.Size(196, 22);
            this.numtextBox.TabIndex = 1;
            this.numtextBox.TextChanged += new System.EventHandler(this.numtextBox_TextChanged);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(39, 94);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(196, 22);
            this.nametextBox.TabIndex = 2;
            this.nametextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер детали";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Закупщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поставщик";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mysqlCommand
            // 
            this.mysqlCommand.CommandText = "InsertDetail";
            this.mysqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            this.mysqlCommand.Connection = this.mysqlConnection;
            this.mysqlCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 30),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@post", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@zak", System.Data.SqlDbType.VarChar, 30),
            new System.Data.SqlClient.SqlParameter("@error", System.Data.SqlDbType.Int, 30, System.Data.ParameterDirection.Output, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // mysqlConnection
            // 
            this.mysqlConnection.ConnectionString = "Data Source=LAPTOP-BB4UDJUK\\SQLEXPRESS;Initial Catalog=\"БД автосалона\";Integrated" +
    " Security=True";
            this.mysqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
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
            // managerslistBindingSource
            // 
            this.managerslistBindingSource.DataMember = "Managerslist";
            this.managerslistBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // managerslistTableAdapter
            // 
            this.managerslistTableAdapter.ClearBeforeFill = true;
            // 
            // numerrorProvider
            // 
            this.numerrorProvider.ContainerControl = this;
            // 
            // zakerrorProvider
            // 
            this.zakerrorProvider.ContainerControl = this;
            // 
            // nameerrorProvider
            // 
            this.nameerrorProvider.ContainerControl = this;
            // 
            // posterrorProvider
            // 
            this.posterrorProvider.ContainerControl = this;
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
            // допОборудованиеDataGridView
            // 
            this.допОборудованиеDataGridView.AutoGenerateColumns = false;
            this.допОборудованиеDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.допОборудованиеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.допОборудованиеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДеталиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.закупщикDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn});
            this.допОборудованиеDataGridView.DataSource = this.detailNotInDealBindingSource;
            this.допОборудованиеDataGridView.Location = new System.Drawing.Point(27, 346);
            this.допОборудованиеDataGridView.Name = "допОборудованиеDataGridView";
            this.допОборудованиеDataGridView.RowHeadersWidth = 51;
            this.допОборудованиеDataGridView.RowTemplate.Height = 24;
            this.допОборудованиеDataGridView.Size = new System.Drawing.Size(553, 446);
            this.допОборудованиеDataGridView.TabIndex = 13;
            this.допОборудованиеDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.допОборудованиеDataGridView_CellContentClick);
            // 
            // номерДеталиDataGridViewTextBoxColumn
            // 
            this.номерДеталиDataGridViewTextBoxColumn.DataPropertyName = "НомерДетали";
            this.номерДеталиDataGridViewTextBoxColumn.HeaderText = "НомерДетали";
            this.номерДеталиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерДеталиDataGridViewTextBoxColumn.Name = "номерДеталиDataGridViewTextBoxColumn";
            this.номерДеталиDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерДеталиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // закупщикDataGridViewTextBoxColumn
            // 
            this.закупщикDataGridViewTextBoxColumn.DataPropertyName = "Закупщик";
            this.закупщикDataGridViewTextBoxColumn.HeaderText = "Закупщик";
            this.закупщикDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.закупщикDataGridViewTextBoxColumn.Name = "закупщикDataGridViewTextBoxColumn";
            this.закупщикDataGridViewTextBoxColumn.ReadOnly = true;
            this.закупщикDataGridViewTextBoxColumn.Width = 125;
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            this.поставщикDataGridViewTextBoxColumn.ReadOnly = true;
            this.поставщикDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailNotInDealBindingSource
            // 
            this.detailNotInDealBindingSource.DataMember = "DetailNotInDeal";
            this.detailNotInDealBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(701, 632);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Поиск по названию";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(903, 634);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(318, 22);
            this.searchtextBox.TabIndex = 17;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(991, 674);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 48);
            this.button2.TabIndex = 18;
            this.button2.Text = "Удалить выбранное значение";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(705, 674);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 48);
            this.button3.TabIndex = 19;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel1.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.gradientPanel1.ColorFillSecond = System.Drawing.Color.Cyan;
            this.gradientPanel1.Controls.Add(this.zaktextBox);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.допОборудованиеDataGridView1);
            this.gradientPanel1.Controls.Add(this.postcomboBox);
            this.gradientPanel1.Controls.Add(this.допОборудованиеDataGridView);
            this.gradientPanel1.Controls.Add(this.button3);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.button2);
            this.gradientPanel1.Controls.Add(this.numtextBox);
            this.gradientPanel1.Controls.Add(this.searchtextBox);
            this.gradientPanel1.Controls.Add(this.nametextBox);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1295, 813);
            this.gradientPanel1.TabIndex = 21;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // zaktextBox
            // 
            this.zaktextBox.Location = new System.Drawing.Point(39, 137);
            this.zaktextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zaktextBox.Name = "zaktextBox";
            this.zaktextBox.ReadOnly = true;
            this.zaktextBox.Size = new System.Drawing.Size(196, 22);
            this.zaktextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(598, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Все детали:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(35, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Остатки деталей:";
            // 
            // допОборудованиеDataGridView1
            // 
            this.допОборудованиеDataGridView1.AutoGenerateColumns = false;
            this.допОборудованиеDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.допОборудованиеDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.допОборудованиеDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.допОборудованиеDataGridView1.DataSource = this.допОборудованиеBindingSource;
            this.допОборудованиеDataGridView1.Location = new System.Drawing.Point(602, 55);
            this.допОборудованиеDataGridView1.Name = "допОборудованиеDataGridView1";
            this.допОборудованиеDataGridView1.RowHeadersWidth = 51;
            this.допОборудованиеDataGridView1.RowTemplate.Height = 24;
            this.допОборудованиеDataGridView1.Size = new System.Drawing.Size(681, 513);
            this.допОборудованиеDataGridView1.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "НомерДетали";
            this.dataGridViewTextBoxColumn1.HeaderText = "НомерДетали";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Закупщик";
            this.dataGridViewTextBoxColumn3.HeaderText = "Закупщик";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Поставщик";
            this.dataGridViewTextBoxColumn4.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // postcomboBox
            // 
            this.postcomboBox.DataSource = this.поставщикBindingSource;
            this.postcomboBox.DisplayMember = "Название";
            this.postcomboBox.FormattingEnabled = true;
            this.postcomboBox.Location = new System.Drawing.Point(39, 178);
            this.postcomboBox.Name = "postcomboBox";
            this.postcomboBox.Size = new System.Drawing.Size(196, 24);
            this.postcomboBox.TabIndex = 20;
            this.postcomboBox.ValueMember = "Название";
            this.postcomboBox.SelectedIndexChanged += new System.EventHandler(this.postcomboBox_SelectedIndexChanged);
            // 
            // managersAndStorekeepersBindingSource
            // 
            this.managersAndStorekeepersBindingSource.DataMember = "ManagersAndStorekeepers";
            this.managersAndStorekeepersBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // managersAndStorekeepersTableAdapter
            // 
            this.managersAndStorekeepersTableAdapter.ClearBeforeFill = true;
            // 
            // detailNotInDealTableAdapter
            // 
            this.detailNotInDealTableAdapter.ClearBeforeFill = true;
            // 
            // CreateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 813);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CreateDetail";
            this.Text = "Редактор списка деталей";
            this.Load += new System.EventHandler(this.CreateDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posterrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNotInDealBindingSource)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.допОборудованиеDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersAndStorekeepersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Data.SqlClient.SqlCommand mysqlCommand;
        private System.Data.SqlClient.SqlConnection mysqlConnection;
        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private БД_автосалонаDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource managerslistBindingSource;
        private БД_автосалонаDataSetTableAdapters.ManagerslistTableAdapter managerslistTableAdapter;
        private System.Windows.Forms.ErrorProvider numerrorProvider;
        private System.Windows.Forms.ErrorProvider zakerrorProvider;
        private System.Windows.Forms.ErrorProvider nameerrorProvider;
        private System.Windows.Forms.ErrorProvider posterrorProvider;
        private System.Windows.Forms.BindingSource допОборудованиеBindingSource;
        private БД_автосалонаDataSetTableAdapters.ДопОборудованиеTableAdapter допОборудованиеTableAdapter;
        private System.Windows.Forms.DataGridView допОборудованиеDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchtextBox;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.BindingSource managersAndStorekeepersBindingSource;
        private БД_автосалонаDataSetTableAdapters.ManagersAndStorekeepersTableAdapter managersAndStorekeepersTableAdapter;
        private System.Windows.Forms.BindingSource detailNotInDealBindingSource;
        private БД_автосалонаDataSetTableAdapters.DetailNotInDealTableAdapter detailNotInDealTableAdapter;
        private System.Windows.Forms.DataGridView допОборудованиеDataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закупщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox zaktextBox;
        private System.Windows.Forms.ComboBox postcomboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}