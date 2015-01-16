namespace Inter
{
    partial class FormYchinform
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
            this.ychebniiPlanInformatikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lilDataSet = new Inter.lilDataSet();
            this.ychebnii_plan_informatikaTableAdapter = new Inter.lilDataSetTableAdapters.Ychebnii_plan_informatikaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ychebniiPlanInformatikaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iddisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exameniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zachetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursovayRabotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayditorniiZadaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lekciiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prakticheskieZadaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samostRabotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semestrDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ychebniiPlanInformatikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychebniiPlanInformatikaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ychebniiPlanInformatikaBindingSource
            // 
            this.ychebniiPlanInformatikaBindingSource.DataMember = "Ychebnii plan informatika";
            this.ychebniiPlanInformatikaBindingSource.DataSource = this.lilDataSet;
            // 
            // lilDataSet
            // 
            this.lilDataSet.DataSetName = "lilDataSet";
            this.lilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ychebnii_plan_informatikaTableAdapter
            // 
            this.ychebnii_plan_informatikaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 419);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddisciplinaDataGridViewTextBoxColumn,
            this.exameniDataGridViewTextBoxColumn,
            this.zachetiDataGridViewTextBoxColumn,
            this.kursovayRabotaDataGridViewTextBoxColumn,
            this.ayditorniiZadaniaDataGridViewTextBoxColumn,
            this.lekciiDataGridViewTextBoxColumn,
            this.prakticheskieZadaniaDataGridViewTextBoxColumn,
            this.examDataGridViewTextBoxColumn,
            this.samostRabotaDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn,
            this.semestrDataGridViewTextBoxColumn1,
            this.semestrDataGridViewTextBoxColumn2,
            this.semestrDataGridViewTextBoxColumn3,
            this.semestrDataGridViewTextBoxColumn4,
            this.semestrDataGridViewTextBoxColumn5,
            this.semestrDataGridViewTextBoxColumn6,
            this.semestrDataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.ychebniiPlanInformatikaBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // ychebniiPlanInformatikaBindingSource1
            // 
            this.ychebniiPlanInformatikaBindingSource1.DataMember = "Ychebnii plan informatika";
            this.ychebniiPlanInformatikaBindingSource1.DataSource = this.lilDataSet;
            // 
            // iddisciplinaDataGridViewTextBoxColumn
            // 
            this.iddisciplinaDataGridViewTextBoxColumn.DataPropertyName = "iddisciplina";
            this.iddisciplinaDataGridViewTextBoxColumn.HeaderText = "iddisciplina";
            this.iddisciplinaDataGridViewTextBoxColumn.Name = "iddisciplinaDataGridViewTextBoxColumn";
            // 
            // exameniDataGridViewTextBoxColumn
            // 
            this.exameniDataGridViewTextBoxColumn.DataPropertyName = "exameni";
            this.exameniDataGridViewTextBoxColumn.HeaderText = "exameni";
            this.exameniDataGridViewTextBoxColumn.Name = "exameniDataGridViewTextBoxColumn";
            // 
            // zachetiDataGridViewTextBoxColumn
            // 
            this.zachetiDataGridViewTextBoxColumn.DataPropertyName = "zacheti";
            this.zachetiDataGridViewTextBoxColumn.HeaderText = "zacheti";
            this.zachetiDataGridViewTextBoxColumn.Name = "zachetiDataGridViewTextBoxColumn";
            // 
            // kursovayRabotaDataGridViewTextBoxColumn
            // 
            this.kursovayRabotaDataGridViewTextBoxColumn.DataPropertyName = "kursovay rabota";
            this.kursovayRabotaDataGridViewTextBoxColumn.HeaderText = "kursovay rabota";
            this.kursovayRabotaDataGridViewTextBoxColumn.Name = "kursovayRabotaDataGridViewTextBoxColumn";
            // 
            // ayditorniiZadaniaDataGridViewTextBoxColumn
            // 
            this.ayditorniiZadaniaDataGridViewTextBoxColumn.DataPropertyName = "ayditornii zadania";
            this.ayditorniiZadaniaDataGridViewTextBoxColumn.HeaderText = "ayditornii zadania";
            this.ayditorniiZadaniaDataGridViewTextBoxColumn.Name = "ayditorniiZadaniaDataGridViewTextBoxColumn";
            // 
            // lekciiDataGridViewTextBoxColumn
            // 
            this.lekciiDataGridViewTextBoxColumn.DataPropertyName = "lekcii";
            this.lekciiDataGridViewTextBoxColumn.HeaderText = "lekcii";
            this.lekciiDataGridViewTextBoxColumn.Name = "lekciiDataGridViewTextBoxColumn";
            // 
            // prakticheskieZadaniaDataGridViewTextBoxColumn
            // 
            this.prakticheskieZadaniaDataGridViewTextBoxColumn.DataPropertyName = "prakticheskie zadania";
            this.prakticheskieZadaniaDataGridViewTextBoxColumn.HeaderText = "prakticheskie zadania";
            this.prakticheskieZadaniaDataGridViewTextBoxColumn.Name = "prakticheskieZadaniaDataGridViewTextBoxColumn";
            // 
            // examDataGridViewTextBoxColumn
            // 
            this.examDataGridViewTextBoxColumn.DataPropertyName = "exam";
            this.examDataGridViewTextBoxColumn.HeaderText = "exam";
            this.examDataGridViewTextBoxColumn.Name = "examDataGridViewTextBoxColumn";
            // 
            // samostRabotaDataGridViewTextBoxColumn
            // 
            this.samostRabotaDataGridViewTextBoxColumn.DataPropertyName = "samost_ rabota";
            this.samostRabotaDataGridViewTextBoxColumn.HeaderText = "samost_ rabota";
            this.samostRabotaDataGridViewTextBoxColumn.Name = "samostRabotaDataGridViewTextBoxColumn";
            // 
            // semestrDataGridViewTextBoxColumn
            // 
            this.semestrDataGridViewTextBoxColumn.DataPropertyName = "1 semestr";
            this.semestrDataGridViewTextBoxColumn.HeaderText = "1 semestr";
            this.semestrDataGridViewTextBoxColumn.Name = "semestrDataGridViewTextBoxColumn";
            // 
            // semestrDataGridViewTextBoxColumn1
            // 
            this.semestrDataGridViewTextBoxColumn1.DataPropertyName = "2 semestr";
            this.semestrDataGridViewTextBoxColumn1.HeaderText = "2 semestr";
            this.semestrDataGridViewTextBoxColumn1.Name = "semestrDataGridViewTextBoxColumn1";
            // 
            // semestrDataGridViewTextBoxColumn2
            // 
            this.semestrDataGridViewTextBoxColumn2.DataPropertyName = "3 semestr";
            this.semestrDataGridViewTextBoxColumn2.HeaderText = "3 semestr";
            this.semestrDataGridViewTextBoxColumn2.Name = "semestrDataGridViewTextBoxColumn2";
            // 
            // semestrDataGridViewTextBoxColumn3
            // 
            this.semestrDataGridViewTextBoxColumn3.DataPropertyName = "4 semestr";
            this.semestrDataGridViewTextBoxColumn3.HeaderText = "4 semestr";
            this.semestrDataGridViewTextBoxColumn3.Name = "semestrDataGridViewTextBoxColumn3";
            // 
            // semestrDataGridViewTextBoxColumn4
            // 
            this.semestrDataGridViewTextBoxColumn4.DataPropertyName = "5 semestr";
            this.semestrDataGridViewTextBoxColumn4.HeaderText = "5 semestr";
            this.semestrDataGridViewTextBoxColumn4.Name = "semestrDataGridViewTextBoxColumn4";
            // 
            // semestrDataGridViewTextBoxColumn5
            // 
            this.semestrDataGridViewTextBoxColumn5.DataPropertyName = "6 semestr";
            this.semestrDataGridViewTextBoxColumn5.HeaderText = "6 semestr";
            this.semestrDataGridViewTextBoxColumn5.Name = "semestrDataGridViewTextBoxColumn5";
            // 
            // semestrDataGridViewTextBoxColumn6
            // 
            this.semestrDataGridViewTextBoxColumn6.DataPropertyName = "7 semestr";
            this.semestrDataGridViewTextBoxColumn6.HeaderText = "7 semestr";
            this.semestrDataGridViewTextBoxColumn6.Name = "semestrDataGridViewTextBoxColumn6";
            // 
            // semestrDataGridViewTextBoxColumn7
            // 
            this.semestrDataGridViewTextBoxColumn7.DataPropertyName = "8 semestr";
            this.semestrDataGridViewTextBoxColumn7.HeaderText = "8 semestr";
            this.semestrDataGridViewTextBoxColumn7.Name = "semestrDataGridViewTextBoxColumn7";
            // 
            // FormYchinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(853, 419);
            this.Controls.Add(this.panel1);
            this.Name = "FormYchinform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебный план направления \"Математика и информатика\"";
            ((System.ComponentModel.ISupportInitialize)(this.ychebniiPlanInformatikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychebniiPlanInformatikaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private lilDataSet lilDataSet;
        private System.Windows.Forms.BindingSource ychebniiPlanInformatikaBindingSource;
        private Inter.lilDataSetTableAdapters.Ychebnii_plan_informatikaTableAdapter ychebnii_plan_informatikaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddisciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exameniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zachetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursovayRabotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayditorniiZadaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lekciiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prakticheskieZadaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn samostRabotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn semestrDataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource ychebniiPlanInformatikaBindingSource1;
    }
}