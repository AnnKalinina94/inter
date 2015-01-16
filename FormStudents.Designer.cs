namespace Inter
{
    partial class FormStudents
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lilDataSet = new Inter.lilDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.fKgroopnapravlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.napravlenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKgroopnapravlBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Inter.lilDataSetTableAdapters.StudentTableAdapter();
            this.napravlenieTableAdapter = new Inter.lilDataSetTableAdapters.NapravlenieTableAdapter();
            this.groopTableAdapter = new Inter.lilDataSetTableAdapters.GroopTableAdapter();
            this.groopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKgroopnapravlBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKKursGroopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter = new Inter.lilDataSetTableAdapters.KursTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgroopnapravlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napravlenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgroopnapravlBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgroopnapravlBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKursGroopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groopBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.lilDataSet;
            // 
            // lilDataSet
            // 
            this.lilDataSet.DataSetName = "lilDataSet";
            this.lilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fKgroopnapravlBindingSource
            // 
            this.fKgroopnapravlBindingSource.DataMember = "FK_groop_napravl";
            this.fKgroopnapravlBindingSource.DataSource = this.napravlenieBindingSource;
            // 
            // napravlenieBindingSource
            // 
            this.napravlenieBindingSource.DataMember = "Napravlenie";
            this.napravlenieBindingSource.DataSource = this.lilDataSet;
            // 
            // fKgroopnapravlBindingSource1
            // 
            this.fKgroopnapravlBindingSource1.DataMember = "FK_groop_napravl";
            this.fKgroopnapravlBindingSource1.DataSource = this.napravlenieBindingSource;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // napravlenieTableAdapter
            // 
            this.napravlenieTableAdapter.ClearBeforeFill = true;
            // 
            // groopTableAdapter
            // 
            this.groopTableAdapter.ClearBeforeFill = true;
            // 
            // groopBindingSource
            // 
            this.groopBindingSource.DataMember = "Groop";
            this.groopBindingSource.DataSource = this.lilDataSet;
            // 
            // fKgroopnapravlBindingSource2
            // 
            this.fKgroopnapravlBindingSource2.DataMember = "FK_groop_napravl";
            this.fKgroopnapravlBindingSource2.DataSource = this.napravlenieBindingSource;
            // 
            // fKKursGroopBindingSource
            // 
            this.fKKursGroopBindingSource.DataMember = "FK_Kurs_Groop";
            this.fKKursGroopBindingSource.DataSource = this.fKgroopnapravlBindingSource;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(560, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 31);
            this.button5.TabIndex = 35;
            this.button5.Text = "Редактировать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.napravlenieBindingSource;
            this.comboBox1.DisplayMember = "napravlenie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Направление";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Группа";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kursBindingSource;
            this.comboBox2.DisplayMember = "kurs";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(356, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.lilDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.groopBindingSource1;
            this.comboBox3.DisplayMember = "groop";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(153, 121);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(356, 21);
            this.comboBox3.TabIndex = 44;
            // 
            // groopBindingSource1
            // 
            this.groopBindingSource1.DataMember = "Groop";
            this.groopBindingSource1.DataSource = this.lilDataSet;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(15, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 269);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Имя";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата рождения";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Документ об обзаровании";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата поступления";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Адресс";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Телефон";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Статус студента";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 32);
            this.button2.TabIndex = 49;
            this.button2.Text = "Вывести";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 480);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.Shown += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgroopnapravlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napravlenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgroopnapravlBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKgroopnapravlBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKursGroopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groopBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lilDataSet lilDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Inter.lilDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource napravlenieBindingSource;
        private Inter.lilDataSetTableAdapters.NapravlenieTableAdapter napravlenieTableAdapter;
        private System.Windows.Forms.BindingSource fKgroopnapravlBindingSource;
        private Inter.lilDataSetTableAdapters.GroopTableAdapter groopTableAdapter;
        private System.Windows.Forms.BindingSource fKgroopnapravlBindingSource1;
        private System.Windows.Forms.BindingSource fKgroopnapravlBindingSource2;
        private System.Windows.Forms.BindingSource fKKursGroopBindingSource;
        private Inter.lilDataSetTableAdapters.KursTableAdapter kursTableAdapter;
        private System.Windows.Forms.BindingSource groopBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private System.Windows.Forms.BindingSource groopBindingSource1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button button2;
    }
}