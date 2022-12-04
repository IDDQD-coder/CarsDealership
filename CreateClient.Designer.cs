
namespace CarsDB
{
    partial class CreateClient
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label номерТелефонаLabel;
            System.Windows.Forms.Label паспортныеДанныеLabel;
            this.label4 = new System.Windows.Forms.Label();
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.номерТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.паспортныеДанныеTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.клиентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gradientPanel1 = new CarsDB.GradientPanel();
            фИОLabel = new System.Windows.Forms.Label();
            номерТелефонаLabel = new System.Windows.Forms.Label();
            паспортныеДанныеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(17, 50);
            фИОLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(42, 17);
            фИОLabel.TabIndex = 8;
            фИОLabel.Text = "ФИО";
            фИОLabel.Click += new System.EventHandler(this.фИОLabel_Click);
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.Location = new System.Drawing.Point(17, 105);
            номерТелефонаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(123, 17);
            номерТелефонаLabel.TabIndex = 9;
            номерТелефонаLabel.Text = "Номер Телефона";
            номерТелефонаLabel.Click += new System.EventHandler(this.номерТелефонаLabel_Click);
            // 
            // паспортныеДанныеLabel
            // 
            паспортныеДанныеLabel.AutoSize = true;
            паспортныеДанныеLabel.Location = new System.Drawing.Point(17, 154);
            паспортныеДанныеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            паспортныеДанныеLabel.Name = "паспортныеДанныеLabel";
            паспортныеДанныеLabel.Size = new System.Drawing.Size(151, 17);
            паспортныеДанныеLabel.TabIndex = 10;
            паспортныеДанныеLabel.Text = "Паспортные Данные:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(535, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Создание клиента";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобильTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеTableAdapter = null;
            this.tableAdapterManager.ДопОборудованиеСделкиTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.СделкаTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.ТестДрайвTableAdapter = null;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.Location = new System.Drawing.Point(21, 70);
            this.фИОTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(299, 22);
            this.фИОTextBox.TabIndex = 9;
            this.фИОTextBox.TextChanged += new System.EventHandler(this.фИОTextBox_TextChanged);
            // 
            // номерТелефонаTextBox
            // 
            this.номерТелефонаTextBox.Location = new System.Drawing.Point(21, 124);
            this.номерТелефонаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номерТелефонаTextBox.MaxLength = 11;
            this.номерТелефонаTextBox.Name = "номерТелефонаTextBox";
            this.номерТелефонаTextBox.Size = new System.Drawing.Size(299, 22);
            this.номерТелефонаTextBox.TabIndex = 10;
            this.номерТелефонаTextBox.TextChanged += new System.EventHandler(this.номерТелефонаTextBox_TextChanged);
            // 
            // паспортныеДанныеTextBox
            // 
            this.паспортныеДанныеTextBox.Location = new System.Drawing.Point(21, 174);
            this.паспортныеДанныеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.паспортныеДанныеTextBox.MaxLength = 10;
            this.паспортныеДанныеTextBox.Name = "паспортныеДанныеTextBox";
            this.паспортныеДанныеTextBox.Size = new System.Drawing.Size(299, 22);
            this.паспортныеДанныеTextBox.TabIndex = 11;
            this.паспортныеДанныеTextBox.TextChanged += new System.EventHandler(this.паспортныеДанныеTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.фИОTextBox);
            this.groupBox1.Controls.Add(паспортныеДанныеLabel);
            this.groupBox1.Controls.Add(фИОLabel);
            this.groupBox1.Controls.Add(this.паспортныеДанныеTextBox);
            this.groupBox1.Controls.Add(this.номерТелефонаTextBox);
            this.groupBox1.Controls.Add(номерТелефонаLabel);
            this.groupBox1.Location = new System.Drawing.Point(878, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 302);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(244, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(118, 619);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск по ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(35, 654);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поиск по номеру телефона";
            this.label2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // клиентDataGridView
            // 
            this.клиентDataGridView.AllowUserToDeleteRows = false;
            this.клиентDataGridView.AutoGenerateColumns = false;
            this.клиентDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.клиентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.клиентDataGridView.DataSource = this.клиентBindingSource;
            this.клиентDataGridView.Location = new System.Drawing.Point(33, 151);
            this.клиентDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.клиентDataGridView.Name = "клиентDataGridView";
            this.клиентDataGridView.RowHeadersWidth = 51;
            this.клиентDataGridView.Size = new System.Drawing.Size(677, 422);
            this.клиентDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НомерТелефона";
            this.dataGridViewTextBoxColumn2.HeaderText = "НомерТелефона";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ПаспортныеДанные";
            this.dataGridViewTextBoxColumn3.HeaderText = "ПаспортныеДанные";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 614);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 653);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 0;
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkRate = 0;
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider3.ContainerControl = this;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.ColorFillFirst = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.gradientPanel1.ColorFillSecond = System.Drawing.Color.Cyan;
            this.gradientPanel1.Controls.Add(this.клиентDataGridView);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.textBox2);
            this.gradientPanel1.Controls.Add(this.textBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1301, 857);
            this.gradientPanel1.TabIndex = 15;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1301, 857);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateClient";
            this.Text = "Создание клиента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateClient_FormClosed);
            this.Load += new System.EventHandler(this.CreateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private БД_автосалонаDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox номерТелефонаTextBox;
        private System.Windows.Forms.TextBox паспортныеДанныеTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView клиентDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private GradientPanel gradientPanel1;
    }
}