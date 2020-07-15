namespace ClientForDataBase
{
    partial class QCAddForm
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
            this.QCGroupBox = new System.Windows.Forms.GroupBox();
            this.DatePurchaseLabel = new System.Windows.Forms.Label();
            this.DateContractLabel = new System.Windows.Forms.Label();
            this.NumberContractLabel = new System.Windows.Forms.Label();
            this.DatePurchaseTextBox = new System.Windows.Forms.TextBox();
            this.DateContractTextBox = new System.Windows.Forms.TextBox();
            this.NumberContractTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.QCGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // QCGroupBox
            // 
            this.QCGroupBox.Controls.Add(this.DatePurchaseLabel);
            this.QCGroupBox.Controls.Add(this.DateContractLabel);
            this.QCGroupBox.Controls.Add(this.NumberContractLabel);
            this.QCGroupBox.Controls.Add(this.DatePurchaseTextBox);
            this.QCGroupBox.Controls.Add(this.DateContractTextBox);
            this.QCGroupBox.Controls.Add(this.NumberContractTextBox);
            this.QCGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QCGroupBox.Location = new System.Drawing.Point(12, 12);
            this.QCGroupBox.Name = "QCGroupBox";
            this.QCGroupBox.Size = new System.Drawing.Size(356, 203);
            this.QCGroupBox.TabIndex = 0;
            this.QCGroupBox.TabStop = false;
            this.QCGroupBox.Text = "Добавление записи";
            // 
            // DatePurchaseLabel
            // 
            this.DatePurchaseLabel.AutoSize = true;
            this.DatePurchaseLabel.Location = new System.Drawing.Point(9, 150);
            this.DatePurchaseLabel.Name = "DatePurchaseLabel";
            this.DatePurchaseLabel.Size = new System.Drawing.Size(191, 24);
            this.DatePurchaseLabel.TabIndex = 7;
            this.DatePurchaseLabel.Text = "Дата приобретения";
            // 
            // DateContractLabel
            // 
            this.DateContractLabel.AutoSize = true;
            this.DateContractLabel.Location = new System.Drawing.Point(9, 93);
            this.DateContractLabel.Name = "DateContractLabel";
            this.DateContractLabel.Size = new System.Drawing.Size(157, 24);
            this.DateContractLabel.TabIndex = 6;
            this.DateContractLabel.Text = "Дата контракта";
            // 
            // NumberContractLabel
            // 
            this.NumberContractLabel.AutoSize = true;
            this.NumberContractLabel.Location = new System.Drawing.Point(6, 46);
            this.NumberContractLabel.Name = "NumberContractLabel";
            this.NumberContractLabel.Size = new System.Drawing.Size(175, 24);
            this.NumberContractLabel.TabIndex = 5;
            this.NumberContractLabel.Text = "Номер контракта";
            // 
            // DatePurchaseTextBox
            // 
            this.DatePurchaseTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePurchaseTextBox.Location = new System.Drawing.Point(210, 151);
            this.DatePurchaseTextBox.Name = "DatePurchaseTextBox";
            this.DatePurchaseTextBox.Size = new System.Drawing.Size(100, 26);
            this.DatePurchaseTextBox.TabIndex = 3;
            this.DatePurchaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateContractTextBox
            // 
            this.DateContractTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateContractTextBox.Location = new System.Drawing.Point(210, 94);
            this.DateContractTextBox.Name = "DateContractTextBox";
            this.DateContractTextBox.Size = new System.Drawing.Size(100, 26);
            this.DateContractTextBox.TabIndex = 2;
            this.DateContractTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumberContractTextBox
            // 
            this.NumberContractTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberContractTextBox.Location = new System.Drawing.Point(210, 47);
            this.NumberContractTextBox.Name = "NumberContractTextBox";
            this.NumberContractTextBox.Size = new System.Drawing.Size(100, 26);
            this.NumberContractTextBox.TabIndex = 1;
            this.NumberContractTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(22, 264);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 49);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(211, 264);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(139, 49);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // QCAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 349);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.QCGroupBox);
            this.Name = "QCAddForm";
            this.Text = "Добавление учетной записи авто";
            this.QCGroupBox.ResumeLayout(false);
            this.QCGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox QCGroupBox;
        private System.Windows.Forms.Label DatePurchaseLabel;
        private System.Windows.Forms.Label DateContractLabel;
        private System.Windows.Forms.Label NumberContractLabel;
        private System.Windows.Forms.TextBox DatePurchaseTextBox;
        private System.Windows.Forms.TextBox DateContractTextBox;
        private System.Windows.Forms.TextBox NumberContractTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
    }
}