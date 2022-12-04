
namespace CarsDB
{
    partial class TestDriveForm
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
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label времяLabel;
            System.Windows.Forms.Label времяLabel1;
            System.Windows.Forms.Label vINАвтомобиляLabel;
            System.Windows.Forms.Label фиоКлиентаLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.тестДрайвBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.timeerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.vinerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.fioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерТестДрайваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vINАвтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тестДрайвTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ТестДрайвTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.testDriveByDateTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.TestDriveByDateTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.vintextBox1 = new System.Windows.Forms.TextBox();
            this.fiotextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchfiotextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gradientPanel2 = new CarsDB.GradientPanel();
            датаLabel = new System.Windows.Forms.Label();
            времяLabel = new System.Windows.Forms.Label();
            времяLabel1 = new System.Windows.Forms.Label();
            vINАвтомобиляLabel = new System.Windows.Forms.Label();
            фиоКлиентаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.тестДрайвBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(117, 42);
            датаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(46, 17);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // времяLabel
            // 
            времяLabel.AutoSize = true;
            времяLabel.Location = new System.Drawing.Point(2102, 1084);
            времяLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            времяLabel.Name = "времяLabel";
            времяLabel.Size = new System.Drawing.Size(0, 17);
            времяLabel.TabIndex = 5;
            времяLabel.Click += new System.EventHandler(this.времяLabel_Click);
            // 
            // времяLabel1
            // 
            времяLabel1.AutoSize = true;
            времяLabel1.Location = new System.Drawing.Point(108, 94);
            времяLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            времяLabel1.Name = "времяLabel1";
            времяLabel1.Size = new System.Drawing.Size(54, 17);
            времяLabel1.TabIndex = 6;
            времяLabel1.Text = "Время:";
            времяLabel1.Click += new System.EventHandler(this.времяLabel1_Click);
            // 
            // vINАвтомобиляLabel
            // 
            vINАвтомобиляLabel.AutoSize = true;
            vINАвтомобиляLabel.Location = new System.Drawing.Point(45, 143);
            vINАвтомобиляLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vINАвтомобиляLabel.Name = "vINАвтомобиляLabel";
            vINАвтомобиляLabel.Size = new System.Drawing.Size(114, 17);
            vINАвтомобиляLabel.TabIndex = 9;
            vINАвтомобиляLabel.Text = "VINАвтомобиля:";
            // 
            // фиоКлиентаLabel
            // 
            фиоКлиентаLabel.AutoSize = true;
            фиоКлиентаLabel.Location = new System.Drawing.Point(61, 193);
            фиоКлиентаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фиоКлиентаLabel.Name = "фиоКлиентаLabel";
            фиоКлиентаLabel.Size = new System.Drawing.Size(101, 17);
            фиоКлиентаLabel.TabIndex = 11;
            фиоКлиентаLabel.Text = "Фио Клиента:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(922, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить клиента";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // тестДрайвBindingSource
            // 
            this.тестДрайвBindingSource.DataMember = "ТестДрайв";
            this.тестДрайвBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(922, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Подобрать автомобиль";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // findbutton
            // 
            this.findbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.findbutton.Location = new System.Drawing.Point(112, 252);
            this.findbutton.Margin = new System.Windows.Forms.Padding(4);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(296, 28);
            this.findbutton.TabIndex = 14;
            this.findbutton.Text = "Записать на тест драйв";
            this.findbutton.UseVisualStyleBackColor = false;
            this.findbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // timeerrorProvider
            // 
            this.timeerrorProvider.ContainerControl = this;
            // 
            // vinerrorProvider
            // 
            this.vinerrorProvider.ContainerControl = this;
            // 
            // fioerrorProvider
            // 
            this.fioerrorProvider.ContainerControl = this;
            // 
            // dateerrorProvider
            // 
            this.dateerrorProvider.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерТестДрайваDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn,
            this.vINАвтомобиляDataGridViewTextBoxColumn,
            this.фиоКлиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.тестДрайвBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 398);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // номерТестДрайваDataGridViewTextBoxColumn
            // 
            this.номерТестДрайваDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.номерТестДрайваDataGridViewTextBoxColumn.DataPropertyName = "НомерТестДрайва";
            this.номерТестДрайваDataGridViewTextBoxColumn.HeaderText = "НомерТестДрайва";
            this.номерТестДрайваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерТестДрайваDataGridViewTextBoxColumn.Name = "номерТестДрайваDataGridViewTextBoxColumn";
            this.номерТестДрайваDataGridViewTextBoxColumn.Visible = false;
            this.номерТестДрайваDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.ToolTipText = "Для изменения даты удалите данную строку";
            this.датаDataGridViewTextBoxColumn.Width = 71;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.ToolTipText = "Для изменения времени удалите данную строку";
            this.времяDataGridViewTextBoxColumn.Width = 79;
            // 
            // vINАвтомобиляDataGridViewTextBoxColumn
            // 
            this.vINАвтомобиляDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vINАвтомобиляDataGridViewTextBoxColumn.DataPropertyName = "VINАвтомобиля";
            this.vINАвтомобиляDataGridViewTextBoxColumn.HeaderText = "VINАвтомобиля";
            this.vINАвтомобиляDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vINАвтомобиляDataGridViewTextBoxColumn.Name = "vINАвтомобиляDataGridViewTextBoxColumn";
            this.vINАвтомобиляDataGridViewTextBoxColumn.Width = 139;
            // 
            // фиоКлиентаDataGridViewTextBoxColumn
            // 
            this.фиоКлиентаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.фиоКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФиоКлиента";
            this.фиоКлиентаDataGridViewTextBoxColumn.HeaderText = "ФиоКлиента";
            this.фиоКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фиоКлиентаDataGridViewTextBoxColumn.Name = "фиоКлиентаDataGridViewTextBoxColumn";
            this.фиоКлиентаDataGridViewTextBoxColumn.Width = 122;
            // 
            // тестДрайвTableAdapter
            // 
            this.тестДрайвTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеСделкиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.СделкаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТестДрайвTableAdapter = this.тестДрайвTableAdapter;
            // 
            // testDriveByDateTableAdapter
            // 
            this.testDriveByDateTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datedateTimePicker1);
            this.groupBox1.Controls.Add(this.timedateTimePicker2);
            this.groupBox1.Controls.Add(this.vintextBox1);
            this.groupBox1.Controls.Add(this.fiotextBox1);
            this.groupBox1.Controls.Add(this.findbutton);
            this.groupBox1.Controls.Add(датаLabel);
            this.groupBox1.Controls.Add(фиоКлиентаLabel);
            this.groupBox1.Controls.Add(времяLabel1);
            this.groupBox1.Controls.Add(vINАвтомобиляLabel);
            this.groupBox1.Location = new System.Drawing.Point(59, 486);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(481, 300);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запись на тест драйв";
            // 
            // datedateTimePicker1
            // 
            this.datedateTimePicker1.Location = new System.Drawing.Point(169, 42);
            this.datedateTimePicker1.MinDate = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            this.datedateTimePicker1.Name = "datedateTimePicker1";
            this.datedateTimePicker1.Size = new System.Drawing.Size(223, 22);
            this.datedateTimePicker1.TabIndex = 28;
            this.datedateTimePicker1.ValueChanged += new System.EventHandler(this.datedateTimePicker1_ValueChanged);
            // 
            // timedateTimePicker2
            // 
            this.timedateTimePicker2.CustomFormat = "HH:mm";
            this.timedateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timedateTimePicker2.Location = new System.Drawing.Point(169, 96);
            this.timedateTimePicker2.Name = "timedateTimePicker2";
            this.timedateTimePicker2.Size = new System.Drawing.Size(95, 22);
            this.timedateTimePicker2.TabIndex = 23;
            this.timedateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // vintextBox1
            // 
            this.vintextBox1.Location = new System.Drawing.Point(169, 143);
            this.vintextBox1.MaxLength = 17;
            this.vintextBox1.Name = "vintextBox1";
            this.vintextBox1.Size = new System.Drawing.Size(239, 22);
            this.vintextBox1.TabIndex = 25;
            this.vintextBox1.TextChanged += new System.EventHandler(this.vintextBox1_TextChanged);
            // 
            // fiotextBox1
            // 
            this.fiotextBox1.Location = new System.Drawing.Point(169, 193);
            this.fiotextBox1.Name = "fiotextBox1";
            this.fiotextBox1.Size = new System.Drawing.Size(239, 22);
            this.fiotextBox1.TabIndex = 23;
            this.fiotextBox1.TextChanged += new System.EventHandler(this.fiotextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(872, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Поиск по ФИО";
            // 
            // searchfiotextBox
            // 
            this.searchfiotextBox.Location = new System.Drawing.Point(731, 524);
            this.searchfiotextBox.Name = "searchfiotextBox";
            this.searchfiotextBox.Size = new System.Drawing.Size(281, 22);
            this.searchfiotextBox.TabIndex = 18;
            this.searchfiotextBox.TextChanged += new System.EventHandler(this.searchfiotextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(786, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 49);
            this.button3.TabIndex = 19;
            this.button3.Text = "Удалить выбранное значение";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(592, 571);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 49);
            this.button4.TabIndex = 21;
            this.button4.Text = "Сохранить изменения";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.Location = new System.Drawing.Point(592, 571);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 49);
            this.button5.TabIndex = 21;
            this.button5.Text = "Сохранить изменения";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1029, 524);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "По всем дням";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.AutoSize = true;
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.gradientPanel2.ColorFillSecond = System.Drawing.Color.Cyan;
            this.gradientPanel2.Controls.Add(this.dataGridView1);
            this.gradientPanel2.Controls.Add(this.checkBox1);
            this.gradientPanel2.Controls.Add(this.button1);
            this.gradientPanel2.Controls.Add(this.button2);
            this.gradientPanel2.Controls.Add(this.button5);
            this.gradientPanel2.Controls.Add(this.groupBox1);
            this.gradientPanel2.Controls.Add(this.button4);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.button3);
            this.gradientPanel2.Controls.Add(this.searchfiotextBox);
            this.gradientPanel2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1301, 845);
            this.gradientPanel2.TabIndex = 23;
            // 
            // TestDriveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 810);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(времяLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TestDriveForm";
            this.Text = "Редатрование списка тест-драйвов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestDriveForm_FormClosed);
            this.Load += new System.EventHandler(this.TestDriveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.тестДрайвBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vinerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource тестДрайвBindingSource;
        private БД_автосалонаDataSetTableAdapters.ТестДрайвTableAdapter тестДрайвTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.ErrorProvider timeerrorProvider;
        private System.Windows.Forms.ErrorProvider vinerrorProvider;
        private System.Windows.Forms.ErrorProvider fioerrorProvider;
        private System.Windows.Forms.ErrorProvider dateerrorProvider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private БД_автосалонаDataSetTableAdapters.TestDriveByDateTableAdapter testDriveByDateTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchfiotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker datedateTimePicker1;
        private System.Windows.Forms.DateTimePicker timedateTimePicker2;
        private System.Windows.Forms.TextBox vintextBox1;
        private System.Windows.Forms.TextBox fiotextBox1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТестДрайваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vINАвтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоКлиентаDataGridViewTextBoxColumn;
    }
}