namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.CreatePrizeLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountValue = new System.Windows.Forms.TextBox();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PrizePercentageValue = new System.Windows.Forms.TextBox();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.Orlabel = new System.Windows.Forms.Label();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberValue.Location = new System.Drawing.Point(262, 95);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(288, 41);
            this.placeNumberValue.TabIndex = 28;
            this.placeNumberValue.TextChanged += new System.EventHandler(this.FirstNameValue_TextChanged);
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlaceNumberLabel.Location = new System.Drawing.Point(23, 98);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(192, 38);
            this.PlaceNumberLabel.TabIndex = 27;
            this.PlaceNumberLabel.Text = "Place Number";
            // 
            // CreatePrizeLabel
            // 
            this.CreatePrizeLabel.AutoSize = true;
            this.CreatePrizeLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeLabel.Location = new System.Drawing.Point(23, 28);
            this.CreatePrizeLabel.Name = "CreatePrizeLabel";
            this.CreatePrizeLabel.Size = new System.Drawing.Size(217, 50);
            this.CreatePrizeLabel.TabIndex = 29;
            this.CreatePrizeLabel.Text = "Create Prize";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameValue.Location = new System.Drawing.Point(262, 166);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(288, 41);
            this.placeNameValue.TabIndex = 31;
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlaceNameLabel.Location = new System.Drawing.Point(23, 167);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(164, 38);
            this.PlaceNameLabel.TabIndex = 30;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountValue
            // 
            this.PrizeAmountValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountValue.Location = new System.Drawing.Point(262, 246);
            this.PrizeAmountValue.Name = "PrizeAmountValue";
            this.PrizeAmountValue.Size = new System.Drawing.Size(288, 41);
            this.PrizeAmountValue.TabIndex = 33;
            this.PrizeAmountValue.Text = "0";
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizeAmountLabel.Location = new System.Drawing.Point(23, 246);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(185, 38);
            this.PrizeAmountLabel.TabIndex = 32;
            this.PrizeAmountLabel.Text = "Prize Amount";
            // 
            // PrizePercentageValue
            // 
            this.PrizePercentageValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageValue.Location = new System.Drawing.Point(267, 367);
            this.PrizePercentageValue.Name = "PrizePercentageValue";
            this.PrizePercentageValue.Size = new System.Drawing.Size(283, 41);
            this.PrizePercentageValue.TabIndex = 35;
            this.PrizePercentageValue.Text = "0";
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizePercentageLabel.Location = new System.Drawing.Point(23, 370);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(224, 38);
            this.PrizePercentageLabel.TabIndex = 34;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // Orlabel
            // 
            this.Orlabel.AutoSize = true;
            this.Orlabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Orlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Orlabel.Location = new System.Drawing.Point(221, 320);
            this.Orlabel.Name = "Orlabel";
            this.Orlabel.Size = new System.Drawing.Size(65, 38);
            this.Orlabel.TabIndex = 36;
            this.Orlabel.Text = "-or-";
            this.Orlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeButton.Location = new System.Drawing.Point(125, 490);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(307, 93);
            this.CreatePrizeButton.TabIndex = 38;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(654, 700);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.Orlabel);
            this.Controls.Add(this.PrizePercentageValue);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountValue);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.CreatePrizeLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox placeNumberValue;
        private Label PlaceNumberLabel;
        private Label CreatePrizeLabel;
        private TextBox placeNameValue;
        private Label PlaceNameLabel;
        private TextBox PrizeAmountValue;
        private Label PrizeAmountLabel;
        private TextBox PrizePercentageValue;
        private Label PrizePercentageLabel;
        private Label Orlabel;
        public Button CreatePrizeButton;
    }
}