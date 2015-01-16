namespace Inter
{
    partial class FormPrepodavateli
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
            System.Windows.Forms.Label idprepodavatelLabel;
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label imaLabel;
            System.Windows.Forms.Label otchestvoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrepodavateli));
            this.lilDataSet = new Inter.lilDataSet();
            this.prepodavateliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepodavateliTableAdapter = new Inter.lilDataSetTableAdapters.PrepodavateliTableAdapter();
            this.prepodavateliBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prepodavateliBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idprepodavatelTextBox = new System.Windows.Forms.TextBox();
            this.familiaTextBox = new System.Windows.Forms.TextBox();
            this.imaTextBox = new System.Windows.Forms.TextBox();
            this.otchestvoTextBox = new System.Windows.Forms.TextBox();
            this.prepodavateliDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idprepodavatelLabel = new System.Windows.Forms.Label();
            familiaLabel = new System.Windows.Forms.Label();
            imaLabel = new System.Windows.Forms.Label();
            otchestvoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavateliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavateliBindingNavigator)).BeginInit();
            this.prepodavateliBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavateliDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idprepodavatelLabel
            // 
            idprepodavatelLabel.AutoSize = true;
            idprepodavatelLabel.Location = new System.Drawing.Point(7, 49);
            idprepodavatelLabel.Name = "idprepodavatelLabel";
            idprepodavatelLabel.Size = new System.Drawing.Size(95, 13);
            idprepodavatelLabel.TabIndex = 1;
            idprepodavatelLabel.Text = "id преподавателя";
            // 
            // familiaLabel
            // 
            familiaLabel.AutoSize = true;
            familiaLabel.Location = new System.Drawing.Point(161, 49);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(56, 13);
            familiaLabel.TabIndex = 3;
            familiaLabel.Text = "Фамилия";
            // 
            // imaLabel
            // 
            imaLabel.AutoSize = true;
            imaLabel.Location = new System.Drawing.Point(323, 49);
            imaLabel.Name = "imaLabel";
            imaLabel.Size = new System.Drawing.Size(29, 13);
            imaLabel.TabIndex = 5;
            imaLabel.Text = "Имя";
            // 
            // otchestvoLabel
            // 
            otchestvoLabel.AutoSize = true;
            otchestvoLabel.Location = new System.Drawing.Point(471, 49);
            otchestvoLabel.Name = "otchestvoLabel";
            otchestvoLabel.Size = new System.Drawing.Size(54, 13);
            otchestvoLabel.TabIndex = 7;
            otchestvoLabel.Text = "Отчество";
            // 
            // lilDataSet
            // 
            this.lilDataSet.DataSetName = "lilDataSet";
            this.lilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepodavateliBindingSource
            // 
            this.prepodavateliBindingSource.DataMember = "Prepodavateli";
            this.prepodavateliBindingSource.DataSource = this.lilDataSet;
            // 
            // prepodavateliTableAdapter
            // 
            this.prepodavateliTableAdapter.ClearBeforeFill = true;
            // 
            // prepodavateliBindingNavigator
            // 
            this.prepodavateliBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prepodavateliBindingNavigator.BindingSource = this.prepodavateliBindingSource;
            this.prepodavateliBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prepodavateliBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prepodavateliBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.prepodavateliBindingNavigatorSaveItem});
            this.prepodavateliBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prepodavateliBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prepodavateliBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prepodavateliBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prepodavateliBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prepodavateliBindingNavigator.Name = "prepodavateliBindingNavigator";
            this.prepodavateliBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prepodavateliBindingNavigator.Size = new System.Drawing.Size(736, 25);
            this.prepodavateliBindingNavigator.TabIndex = 0;
            this.prepodavateliBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // prepodavateliBindingNavigatorSaveItem
            // 
            this.prepodavateliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prepodavateliBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prepodavateliBindingNavigatorSaveItem.Image")));
            this.prepodavateliBindingNavigatorSaveItem.Name = "prepodavateliBindingNavigatorSaveItem";
            this.prepodavateliBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.prepodavateliBindingNavigatorSaveItem.Text = "Save Data";
            this.prepodavateliBindingNavigatorSaveItem.Click += new System.EventHandler(this.prepodavateliBindingNavigatorSaveItem_Click);
            // 
            // idprepodavatelTextBox
            // 
            this.idprepodavatelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prepodavateliBindingSource, "idprepodavatel", true));
            this.idprepodavatelTextBox.Location = new System.Drawing.Point(10, 69);
            this.idprepodavatelTextBox.Name = "idprepodavatelTextBox";
            this.idprepodavatelTextBox.Size = new System.Drawing.Size(120, 20);
            this.idprepodavatelTextBox.TabIndex = 2;
            // 
            // familiaTextBox
            // 
            this.familiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prepodavateliBindingSource, "familia", true));
            this.familiaTextBox.Location = new System.Drawing.Point(164, 69);
            this.familiaTextBox.Name = "familiaTextBox";
            this.familiaTextBox.Size = new System.Drawing.Size(120, 20);
            this.familiaTextBox.TabIndex = 4;
            // 
            // imaTextBox
            // 
            this.imaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prepodavateliBindingSource, "ima", true));
            this.imaTextBox.Location = new System.Drawing.Point(326, 69);
            this.imaTextBox.Name = "imaTextBox";
            this.imaTextBox.Size = new System.Drawing.Size(120, 20);
            this.imaTextBox.TabIndex = 6;
            // 
            // otchestvoTextBox
            // 
            this.otchestvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prepodavateliBindingSource, "otchestvo", true));
            this.otchestvoTextBox.Location = new System.Drawing.Point(474, 69);
            this.otchestvoTextBox.Name = "otchestvoTextBox";
            this.otchestvoTextBox.Size = new System.Drawing.Size(120, 20);
            this.otchestvoTextBox.TabIndex = 8;
            // 
            // prepodavateliDataGridView
            // 
            this.prepodavateliDataGridView.AutoGenerateColumns = false;
            this.prepodavateliDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.prepodavateliDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.prepodavateliDataGridView.DataSource = this.prepodavateliBindingSource;
            this.prepodavateliDataGridView.Location = new System.Drawing.Point(10, 107);
            this.prepodavateliDataGridView.Name = "prepodavateliDataGridView";
            this.prepodavateliDataGridView.Size = new System.Drawing.Size(492, 207);
            this.prepodavateliDataGridView.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(530, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 40);
            this.button4.TabIndex = 13;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idprepodavatel";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID преподавателя";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "familia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ima";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "otchestvo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormPrepodavateli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prepodavateliDataGridView);
            this.Controls.Add(idprepodavatelLabel);
            this.Controls.Add(this.idprepodavatelTextBox);
            this.Controls.Add(familiaLabel);
            this.Controls.Add(this.familiaTextBox);
            this.Controls.Add(imaLabel);
            this.Controls.Add(this.imaTextBox);
            this.Controls.Add(otchestvoLabel);
            this.Controls.Add(this.otchestvoTextBox);
            this.Controls.Add(this.prepodavateliBindingNavigator);
            this.Name = "FormPrepodavateli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список преподавателей";
            this.Load += new System.EventHandler(this.FormPrepodavateli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavateliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavateliBindingNavigator)).EndInit();
            this.prepodavateliBindingNavigator.ResumeLayout(false);
            this.prepodavateliBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavateliDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lilDataSet lilDataSet;
        private System.Windows.Forms.BindingSource prepodavateliBindingSource;
        private Inter.lilDataSetTableAdapters.PrepodavateliTableAdapter prepodavateliTableAdapter;
        private System.Windows.Forms.BindingNavigator prepodavateliBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton prepodavateliBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idprepodavatelTextBox;
        private System.Windows.Forms.TextBox familiaTextBox;
        private System.Windows.Forms.TextBox imaTextBox;
        private System.Windows.Forms.TextBox otchestvoTextBox;
        private System.Windows.Forms.DataGridView prepodavateliDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}