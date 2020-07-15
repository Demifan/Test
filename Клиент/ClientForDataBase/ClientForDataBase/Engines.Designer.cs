namespace ClientForDataBase
{
    partial class Engines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engines));
            this.EDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new ClientForDataBase.TestDataSet();
            this.enginesTableAdapter = new ClientForDataBase.TestDataSetTableAdapters.EnginesTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.QuantitativeComposition = new System.Windows.Forms.ToolStripButton();
            this.LightCars = new System.Windows.Forms.ToolStripButton();
            this.HeavyCars = new System.Windows.Forms.ToolStripButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDataGridView
            // 
            this.EDataGridView.AutoGenerateColumns = false;
            this.EDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.EDataGridView.DataSource = this.enginesBindingSource;
            this.EDataGridView.Location = new System.Drawing.Point(12, 47);
            this.EDataGridView.Name = "EDataGridView";
            this.EDataGridView.Size = new System.Drawing.Size(565, 262);
            this.EDataGridView.TabIndex = 1;
            this.EDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.EDataGridView_UserDeletingRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 130;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 130;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.Width = 130;
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Объём";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            this.volumeDataGridViewTextBoxColumn.Width = 130;
            // 
            // enginesBindingSource
            // 
            this.enginesBindingSource.DataMember = "Engines";
            this.enginesBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enginesTableAdapter
            // 
            this.enginesTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuantitativeComposition,
            this.LightCars,
            this.HeavyCars});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(581, 37);
            this.toolStrip1.TabIndex = 5;
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
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(12, 343);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 60);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(210, 343);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 60);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(401, 343);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(160, 60);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Engines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EDataGridView);
            this.Name = "Engines";
            this.Text = "Engines";
            this.Load += new System.EventHandler(this.Engines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView EDataGridView;
        public TestDataSet testDataSet;
        public System.Windows.Forms.BindingSource enginesBindingSource;
        public TestDataSetTableAdapters.EnginesTableAdapter enginesTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton QuantitativeComposition;
        private System.Windows.Forms.ToolStripButton LightCars;
        private System.Windows.Forms.ToolStripButton HeavyCars;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
    }
}