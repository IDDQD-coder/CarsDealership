
namespace CarsDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.бД_автосалонаDataSet = new CarsDB.БД_автосалонаDataSet();
            this.managerslistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerslistTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.ManagerslistTableAdapter();
            this.tableAdapterManager = new CarsDB.БД_автосалонаDataSetTableAdapters.TableAdapterManager();
            this.сотрудникTableAdapter = new CarsDB.БД_автосалонаDataSetTableAdapters.СотрудникTableAdapter();
            this.managerslistComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmanComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerslistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(349, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите роль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(325, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Консультант",
            "Продавец",
            "Механик",
            "Менеджер"});
            this.comboBox1.Location = new System.Drawing.Point(354, 345);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 30);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "БД Автосалона";
            // 
            // бД_автосалонаDataSet
            // 
            this.бД_автосалонаDataSet.DataSetName = "БД_автосалонаDataSet";
            this.бД_автосалонаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.ТестДрайвTableAdapter = null;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // managerslistComboBox
            // 
            this.managerslistComboBox.DataSource = this.managerslistBindingSource;
            this.managerslistComboBox.DisplayMember = "ФИО";
            this.managerslistComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.managerslistComboBox.FormattingEnabled = true;
            this.managerslistComboBox.Location = new System.Drawing.Point(269, 397);
            this.managerslistComboBox.Name = "managerslistComboBox";
            this.managerslistComboBox.Size = new System.Drawing.Size(351, 30);
            this.managerslistComboBox.TabIndex = 9;
            this.managerslistComboBox.ValueMember = "ФИО";
            this.managerslistComboBox.Visible = false;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.бД_автосалонаDataSet;
            // 
            // salesmanComboBox
            // 
            this.salesmanComboBox.DataSource = this.сотрудникBindingSource;
            this.salesmanComboBox.DisplayMember = "ФИО";
            this.salesmanComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.salesmanComboBox.FormattingEnabled = true;
            this.salesmanComboBox.Location = new System.Drawing.Point(269, 397);
            this.salesmanComboBox.Name = "salesmanComboBox";
            this.salesmanComboBox.Size = new System.Drawing.Size(351, 30);
            this.salesmanComboBox.TabIndex = 9;
            this.salesmanComboBox.ValueMember = "ФИО";
            this.salesmanComboBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(178)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(913, 908);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerslistComboBox);
            this.Controls.Add(this.salesmanComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Селектор должности";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бД_автосалонаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerslistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private БД_автосалонаDataSet бД_автосалонаDataSet;
        private System.Windows.Forms.BindingSource managerslistBindingSource;
        private БД_автосалонаDataSetTableAdapters.ManagerslistTableAdapter managerslistTableAdapter;
        private БД_автосалонаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox managerslistComboBox;
        private БД_автосалонаDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private System.Windows.Forms.ComboBox salesmanComboBox;
    }
}

