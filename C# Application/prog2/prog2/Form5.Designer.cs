namespace prog2
{
    partial class Form5
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
            this.equipmentNumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new prog2.DataSet1();
            this.equipmentNumerTableAdapter = new prog2.DataSet1TableAdapters.EquipmentNumerTableAdapter();
            this.faultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faultTableAdapter = new prog2.DataSet1TableAdapters.FaultTableAdapter();
            this.tableAdapterManager = new prog2.DataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mechFaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mechFaultTableAdapter = new prog2.DataSet1TableAdapters.MechFaultTableAdapter();
            this.mechFaultDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electFaultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electFaultTableAdapter = new prog2.DataSet1TableAdapters.ElectFaultTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electFaultDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faultDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKFaultequip75035A771BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentNumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechFaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechFaultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electFaultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electFaultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFaultequip75035A771BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmentNumerBindingSource
            // 
            this.equipmentNumerBindingSource.DataMember = "EquipmentNumer";
            this.equipmentNumerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentNumerTableAdapter
            // 
            this.equipmentNumerTableAdapter.ClearBeforeFill = true;
            // 
            // faultBindingSource
            // 
            this.faultBindingSource.DataMember = "FK__Fault__equip__75035A771";
            this.faultBindingSource.DataSource = this.equipmentNumerBindingSource;
            // 
            // faultTableAdapter
            // 
            this.faultTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.ElectFaultTableAdapter = null;
            this.tableAdapterManager.EngineerTableAdapter = null;
            this.tableAdapterManager.EquipmentNumerTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.FaultTableAdapter = this.faultTableAdapter;
            this.tableAdapterManager.MechFaultTableAdapter = null;
            this.tableAdapterManager.PhoneTableAdapter = null;
            this.tableAdapterManager.RepairsTableAdapter = null;
            this.tableAdapterManager.SpecialtyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prog2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Faults";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Equipment ID:";
            // 
            // mechFaultBindingSource
            // 
            this.mechFaultBindingSource.DataMember = "MechFault";
            this.mechFaultBindingSource.DataSource = this.dataSet1;
            // 
            // mechFaultTableAdapter
            // 
            this.mechFaultTableAdapter.ClearBeforeFill = true;
            // 
            // mechFaultDataGridView
            // 
            this.mechFaultDataGridView.AutoGenerateColumns = false;
            this.mechFaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechFaultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mechFaultDataGridView.DataSource = this.mechFaultBindingSource;
            this.mechFaultDataGridView.Location = new System.Drawing.Point(463, 92);
            this.mechFaultDataGridView.Name = "mechFaultDataGridView";
            this.mechFaultDataGridView.Size = new System.Drawing.Size(243, 220);
            this.mechFaultDataGridView.TabIndex = 6;
            this.mechFaultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mechFaultDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mPartNum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fault";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fault ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // electFaultBindingSource
            // 
            this.electFaultBindingSource.DataMember = "ElectFault";
            this.electFaultBindingSource.DataSource = this.dataSet1;
            // 
            // electFaultTableAdapter
            // 
            this.electFaultTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mechanical Faults";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Electrical Faults";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(620, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fault Breakdown";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fault";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fault ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ePartNum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Part Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // electFaultDataGridView
            // 
            this.electFaultDataGridView.AutoGenerateColumns = false;
            this.electFaultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.electFaultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.electFaultDataGridView.DataSource = this.electFaultBindingSource;
            this.electFaultDataGridView.Location = new System.Drawing.Point(712, 92);
            this.electFaultDataGridView.Name = "electFaultDataGridView";
            this.electFaultDataGridView.Size = new System.Drawing.Size(243, 220);
            this.electFaultDataGridView.TabIndex = 7;
            this.electFaultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.electFaultDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "faultDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "faultID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fault ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // faultDataGridView
            // 
            this.faultDataGridView.AutoGenerateColumns = false;
            this.faultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.faultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.faultDataGridView.DataSource = this.faultBindingSource;
            this.faultDataGridView.Location = new System.Drawing.Point(58, 92);
            this.faultDataGridView.Name = "faultDataGridView";
            this.faultDataGridView.Size = new System.Drawing.Size(343, 220);
            this.faultDataGridView.TabIndex = 1;
            this.faultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.faultDataGridView_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.equipmentNumerBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "equipID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fKFaultequip75035A771BindingSource
            // 
            this.fKFaultequip75035A771BindingSource.DataMember = "FK__Fault__equip__75035A771";
            this.fKFaultequip75035A771BindingSource.DataSource = this.equipmentNumerBindingSource;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.electFaultDataGridView);
            this.Controls.Add(this.mechFaultDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.faultDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form5";
            this.Text = "Faults";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentNumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechFaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechFaultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electFaultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electFaultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFaultequip75035A771BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource equipmentNumerBindingSource;
        private DataSet1TableAdapters.EquipmentNumerTableAdapter equipmentNumerTableAdapter;
        private System.Windows.Forms.BindingSource faultBindingSource;
        private DataSet1TableAdapters.FaultTableAdapter faultTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource mechFaultBindingSource;
        private DataSet1TableAdapters.MechFaultTableAdapter mechFaultTableAdapter;
        private System.Windows.Forms.DataGridView mechFaultDataGridView;
        private System.Windows.Forms.BindingSource electFaultBindingSource;
        private DataSet1TableAdapters.ElectFaultTableAdapter electFaultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView electFaultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView faultDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource fKFaultequip75035A771BindingSource;
    }
}