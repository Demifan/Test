namespace ClientForDataBase
{
    partial class QCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QCForm));
            this.QCdataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitativeCompositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new ClientForDataBase.TestDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantitativeCompositionTableAdapter = new ClientForDataBase.TestDataSetTableAdapters.QuantitativeCompositionTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Engines = new System.Windows.Forms.ToolStripButton();
            this.LightCars = new System.Windows.Forms.ToolStripButton();
            this.HeavyCars = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.QCdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitativeCompositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QCdataGridView
            // 
            this.QCdataGridView.AutoGenerateColumns = false;
            this.QCdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QCdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberContractDataGridViewTextBoxColumn,
            this.dateContractDataGridViewTextBoxColumn,
            this.datePurchaseDataGridViewTextBoxColumn});
            this.QCdataGridView.DataSource = this.quantitativeCompositionBindingSource;
            this.QCdataGridView.Location = new System.Drawing.Point(0, 64);
            this.QCdataGridView.Name = "QCdataGridView";
            this.QCdataGridView.Size = new System.Drawing.Size(565, 262);
            this.QCdataGridView.TabIndex = 0;
            this.QCdataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // numberContractDataGridViewTextBoxColumn
            // 
            this.numberContractDataGridViewTextBoxColumn.DataPropertyName = "NumberContract";
            this.numberContractDataGridViewTextBoxColumn.HeaderText = "Номер контракта";
            this.numberContractDataGridViewTextBoxColumn.Name = "numberContractDataGridViewTextBoxColumn";
            this.numberContractDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateContractDataGridViewTextBoxColumn
            // 
            this.dateContractDataGridViewTextBoxColumn.DataPropertyName = "DateContract";
            this.dateContractDataGridViewTextBoxColumn.HeaderText = "Дата контракта";
            this.dateContractDataGridViewTextBoxColumn.Name = "dateContractDataGridViewTextBoxColumn";
            this.dateContractDataGridViewTextBoxColumn.Width = 130;
            // 
            // datePurchaseDataGridViewTextBoxColumn
            // 
            this.datePurchaseDataGridViewTextBoxColumn.DataPropertyName = "DatePurchase";
            this.datePurchaseDataGridViewTextBoxColumn.HeaderText = "Дата приобретения";
            this.datePurchaseDataGridViewTextBoxColumn.Name = "datePurchaseDataGridViewTextBoxColumn";
            this.datePurchaseDataGridViewTextBoxColumn.Width = 130;
            // 
            // quantitativeCompositionBindingSource
            // 
            this.quantitativeCompositionBindingSource.DataMember = "QuantitativeComposition";
            this.quantitativeCompositionBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // quantitativeCompositionTableAdapter
            // 
            this.quantitativeCompositionTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 354);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 60);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(194, 354);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 60);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(382, 354);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 60);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Engines,
            this.LightCars,
            this.HeavyCars});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 37);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Engines
            // 
            this.Engines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Engines.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Engines.Image = ((System.Drawing.Image)(resources.GetObject("Engines.Image")));
            this.Engines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Engines.Name = "Engines";
            this.Engines.Size = new System.Drawing.Size(124, 34);
            this.Engines.Text = "Двигатели";
            this.Engines.ToolTipText = "Двигатели";
            this.Engines.Click += new System.EventHandler(this.Engines_Click);
            // 
            // LightCars
            // 
            this.LightCars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LightCars.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LightCars.Image = ((System.Drawing.Image)(resources.GetObject("LightCars.Image")));
            this.LightCars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LightCars.Name = "LightCars";
            this.LightCars.Size = new System.Drawing.Size(169, 34);
            this.LightCars.Text = "Легковые авто";
            this.LightCars.Click += new System.EventHandler(this.LightCars_Click);
            // 
            // HeavyCars
            // 
            this.HeavyCars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HeavyCars.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeavyCars.Image = ((System.Drawing.Image)(resources.GetObject("HeavyCars.Image")));
            this.HeavyCars.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HeavyCars.Name = "HeavyCars";
            this.HeavyCars.Size = new System.Drawing.Size(166, 34);
            this.HeavyCars.Text = "Грузовые авто";
            this.HeavyCars.Click += new System.EventHandler(this.HeavyCars_Click);
            // 
            // QCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 427);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.QCdataGridView);
            this.Name = "QCForm";
            this.Text = "Учет автомобилей";
            this.Load += new System.EventHandler(this.QCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QCdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitativeCompositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView QCdataGridView;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        public TestDataSet testDataSet;
        public System.Windows.Forms.BindingSource quantitativeCompositionBindingSource;
        public TestDataSetTableAdapters.QuantitativeCompositionTableAdapter quantitativeCompositionTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Engines;
        private System.Windows.Forms.ToolStripButton LightCars;
        private System.Windows.Forms.ToolStripButton HeavyCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchaseDataGridViewTextBoxColumn;
    }
}

