namespace ClientForDataBase
{
    partial class EnginesAddForm
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
            this.EGroupBox = new System.Windows.Forms.GroupBox();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EGroupBox
            // 
            this.EGroupBox.Controls.Add(this.VolumeLabel);
            this.EGroupBox.Controls.Add(this.PowerLabel);
            this.EGroupBox.Controls.Add(this.TypeLabel);
            this.EGroupBox.Controls.Add(this.VolumeTextBox);
            this.EGroupBox.Controls.Add(this.PowerTextBox);
            this.EGroupBox.Controls.Add(this.TypeTextBox);
            this.EGroupBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EGroupBox.Name = "EGroupBox";
            this.EGroupBox.Size = new System.Drawing.Size(269, 203);
            this.EGroupBox.TabIndex = 1;
            this.EGroupBox.TabStop = false;
            this.EGroupBox.Text = "Добавление записи";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(9, 150);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(72, 24);
            this.VolumeLabel.TabIndex = 7;
            this.VolumeLabel.Text = "Объем";
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(9, 93);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(110, 24);
            this.PowerLabel.TabIndex = 6;
            this.PowerLabel.Text = "Мощность";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(6, 46);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(46, 24);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Тип";
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeTextBox.Location = new System.Drawing.Point(140, 150);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(100, 26);
            this.VolumeTextBox.TabIndex = 3;
            this.VolumeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerTextBox.Location = new System.Drawing.Point(140, 94);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(100, 26);
            this.PowerTextBox.TabIndex = 2;
            this.PowerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeTextBox.Location = new System.Drawing.Point(140, 47);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(100, 26);
            this.TypeTextBox.TabIndex = 1;
            this.TypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 230);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(161, 230);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 50);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EnginesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 289);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EGroupBox);
            this.Name = "EnginesAddForm";
            this.Text = "Добавление двигателя";
            this.EGroupBox.ResumeLayout(false);
            this.EGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EGroupBox;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CloseButton;
    }
}