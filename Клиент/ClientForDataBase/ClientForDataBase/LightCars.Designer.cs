namespace ClientForDataBase
{
    partial class LightCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightCars));
            this.LCDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearManufactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeTransmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberGearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lightCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new ClientForDataBase.TestDataSet();
            this.lightCarsTableAdapter = new ClientForDataBase.TestDataSetTableAdapters.LightCarsTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.QuantitativeComposition = new System.Windows.Forms.ToolStripButton();
            this.Engines = new System.Windows.Forms.ToolStripButton();
            this.HeavyCars = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.LCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCDataGridView
            // 
            this.LCDataGridView.AutoGenerateColumns = false;
            this.LCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.contractIdDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.yearManufactureDataGridViewTextBoxColumn,
            this.engineIdDataGridViewTextBoxColumn,
            this.typeTransmissionDataGridViewTextBoxColumn,
            this.numberGearsDataGridViewTextBoxColumn,
            this.bodyTypeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn});
            this.LCDataGridView.DataSource = this.lightCarsBindingSource;
            this.LCDataGridView.Location = new System.Drawing.Point(0, 40);
            this.LCDataGridView.Name = "LCDataGridView";
            this.LCDataGridView.Size = new System.Drawing.Size(747, 319);
            this.LCDataGridView.TabIndex = 0;
            this.LCDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.LCarsDataGridView_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractIdDataGridViewTextBoxColumn
            // 
            this.contractIdDataGridViewTextBoxColumn.DataPropertyName = "ContractId";
            this.contractIdDataGridViewTextBoxColumn.HeaderText = "Id Контракта";
            this.contractIdDataGridViewTextBoxColumn.Name = "contractIdDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 170;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Высота";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // yearManufactureDataGridViewTextBoxColumn
            // 
            this.yearManufactureDataGridViewTextBoxColumn.DataPropertyName = "YearManufacture";
            this.yearManufactureDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.yearManufactureDataGridViewTextBoxColumn.Name = "yearManufactureDataGridViewTextBoxColumn";
            // 
            // engineIdDataGridViewTextBoxColumn
            // 
            this.engineIdDataGridViewTextBoxColumn.DataPropertyName = "EngineId";
            this.engineIdDataGridViewTextBoxColumn.HeaderText = "Id Двигателя";
            this.engineIdDataGridViewTextBoxColumn.Name = "engineIdDataGridViewTextBoxColumn";
            // 
            // typeTransmissionDataGridViewTextBoxColumn
            // 
            this.typeTransmissionDataGridViewTextBoxColumn.DataPropertyName = "TypeTransmission";
            this.typeTransmissionDataGridViewTextBoxColumn.HeaderText = "Тип коробки передач";
            this.typeTransmissionDataGridViewTextBoxColumn.Name = "typeTransmissionDataGridViewTextBoxColumn";
            // 
            // numberGearsDataGridViewTextBoxColumn
            // 
            this.numberGearsDataGridViewTextBoxColumn.DataPropertyName = "NumberGears";
            this.numberGearsDataGridViewTextBoxColumn.HeaderText = "Количество передач";
            this.numberGearsDataGridViewTextBoxColumn.Name = "numberGearsDataGridViewTextBoxColumn";
            // 
            // bodyTypeDataGridViewTextBoxColumn
            // 
            this.bodyTypeDataGridViewTextBoxColumn.DataPropertyName = "BodyType";
            this.bodyTypeDataGridViewTextBoxColumn.HeaderText = "Тип кузова";
            this.bodyTypeDataGridViewTextBoxColumn.Name = "bodyTypeDataGridViewTextBoxColumn";
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Вместимость";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            // 
            // lightCarsBindingSource
            // 
            this.lightCarsBindingSource.DataMember = "LightCars";
            this.lightCarsBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lightCarsTableAdapter
            // 
            this.lightCarsTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 378);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 60);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(272, 378);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 60);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(546, 378);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 60);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuantitativeComposition,
            this.Engines,
            this.HeavyCars});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(751, 37);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // QuantitativeComposition
            // 
            this.QuantitativeComposition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.QuantitativeComposition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantitativeComposition.Image = ((System.Drawing.Image)(resources.GetObject("QuantitativeComposition.Image")));
            this.QuantitativeComposition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuantitativeComposition.Name = "QuantitativeComposition";
            this.QuantitativeComposition.Size = new System.Drawing.Size(208, 34);
            this.QuantitativeComposition.Text = "Учет автомобилей";
            this.QuantitativeComposition.ToolTipText = "Учет авто";
            this.QuantitativeComposition.Click += new System.EventHandler(this.QuantitativeComposition_Click);
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
            this.Engines.Click += new System.EventHandler(this.Engines_Click);
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
            // LightCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LCDataGridView);
            this.Name = "LightCars";
            this.Text = "Легковые машины";
            this.Load += new System.EventHandler(this.LightCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView LCDataGridView;
        public TestDataSet testDataSet;
        public System.Windows.Forms.BindingSource lightCarsBindingSource;
        public TestDataSetTableAdapters.LightCarsTableAdapter lightCarsTableAdapter;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton QuantitativeComposition;
        private System.Windows.Forms.ToolStripButton Engines;
        private System.Windows.Forms.ToolStripButton HeavyCars;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearManufactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeTransmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberGearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
    }
}