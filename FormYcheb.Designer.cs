namespace Inter
{
    partial class FormYcheb
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
            this.lilDataSet = new Inter.lilDataSet();
            this.ychebniiPlanInformatikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ychebnii_plan_informatikaTableAdapter = new Inter.lilDataSetTableAdapters.Ychebnii_plan_informatikaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychebniiPlanInformatikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(498, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lilDataSet
            // 
            this.lilDataSet.DataSetName = "lilDataSet";
            this.lilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ychebniiPlanInformatikaBindingSource
            // 
            this.ychebniiPlanInformatikaBindingSource.DataMember = "Ychebnii plan informatika";
            this.ychebniiPlanInformatikaBindingSource.DataSource = this.lilDataSet;
            // 
            // ychebnii_plan_informatikaTableAdapter
            // 
            this.ychebnii_plan_informatikaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Учебный план направления \"Информатика\"";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "Учебный план направления \" Педагогическое образование\"";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormYcheb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(642, 344);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormYcheb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебные планы";
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ychebniiPlanInformatikaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private lilDataSet lilDataSet;
        private System.Windows.Forms.BindingSource ychebniiPlanInformatikaBindingSource;
        private Inter.lilDataSetTableAdapters.Ychebnii_plan_informatikaTableAdapter ychebnii_plan_informatikaTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}