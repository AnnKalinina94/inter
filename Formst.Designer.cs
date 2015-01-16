namespace Inter
{
    partial class Formst
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxDocumentOnEducation = new System.Windows.Forms.TextBox();
            this.textBoxDateOfAdmission = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lilDataSet = new Inter.lilDataSet();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter = new Inter.lilDataSetTableAdapters.KursTableAdapter();
            this.napravlenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.napravlenieTableAdapter = new Inter.lilDataSetTableAdapters.NapravlenieTableAdapter();
            this.groopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groopTableAdapter = new Inter.lilDataSetTableAdapters.GroopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.napravlenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(27, 42);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(133, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(173, 42);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(131, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(326, 42);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(142, 20);
            this.textBoxPatronymic.TabIndex = 2;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(27, 125);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(133, 20);
            this.textBoxDateOfBirth.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(173, 125);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(131, 20);
            this.textBoxPhone.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(27, 196);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(424, 20);
            this.textBoxAddress.TabIndex = 5;
            // 
            // textBoxDocumentOnEducation
            // 
            this.textBoxDocumentOnEducation.Location = new System.Drawing.Point(27, 282);
            this.textBoxDocumentOnEducation.Name = "textBoxDocumentOnEducation";
            this.textBoxDocumentOnEducation.Size = new System.Drawing.Size(133, 20);
            this.textBoxDocumentOnEducation.TabIndex = 6;
            // 
            // textBoxDateOfAdmission
            // 
            this.textBoxDateOfAdmission.Location = new System.Drawing.Point(173, 282);
            this.textBoxDateOfAdmission.Name = "textBoxDateOfAdmission";
            this.textBoxDateOfAdmission.Size = new System.Drawing.Size(131, 20);
            this.textBoxDateOfAdmission.TabIndex = 7;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(326, 282);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(125, 20);
            this.textBoxStatus.TabIndex = 8;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DataSource = this.kursBindingSource;
            this.comboBoxCourse.DisplayMember = "kurs";
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(27, 357);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourse.TabIndex = 9;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DataSource = this.napravlenieBindingSource;
            this.comboBoxDirection.DisplayMember = "napravlenie";
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(173, 356);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDirection.TabIndex = 10;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.groopBindingSource;
            this.comboBoxGroup.DisplayMember = "groop";
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(326, 357);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroup.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Фамилия";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Адрес проживания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Документ об обрзовании";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Дата поступления";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Статут студента";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Курс";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Направление";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Группа";
            // 
            // lilDataSet
            // 
            this.lilDataSet.DataSetName = "lilDataSet";
            this.lilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.lilDataSet;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // napravlenieBindingSource
            // 
            this.napravlenieBindingSource.DataMember = "Napravlenie";
            this.napravlenieBindingSource.DataSource = this.lilDataSet;
            // 
            // napravlenieTableAdapter
            // 
            this.napravlenieTableAdapter.ClearBeforeFill = true;
            // 
            // groopBindingSource
            // 
            this.groopBindingSource.DataMember = "Groop";
            this.groopBindingSource.DataSource = this.lilDataSet;
            // 
            // groopTableAdapter
            // 
            this.groopTableAdapter.ClearBeforeFill = true;
            // 
            // Formst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 426);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxDateOfAdmission);
            this.Controls.Add(this.textBoxDocumentOnEducation);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "Formst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировние";
            this.Load += new System.EventHandler(this.Formst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.napravlenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxDocumentOnEducation;
        private System.Windows.Forms.TextBox textBoxDateOfAdmission;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private lilDataSet lilDataSet;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Inter.lilDataSetTableAdapters.KursTableAdapter kursTableAdapter;
        private System.Windows.Forms.BindingSource napravlenieBindingSource;
        private Inter.lilDataSetTableAdapters.NapravlenieTableAdapter napravlenieTableAdapter;
        private System.Windows.Forms.BindingSource groopBindingSource;
        private Inter.lilDataSetTableAdapters.GroopTableAdapter groopTableAdapter;
    }
}