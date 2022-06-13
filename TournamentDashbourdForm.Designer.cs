namespace TrackerUI
{
    partial class TournamentDashbourdForm
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
            this.CreatePrizeLabel = new System.Windows.Forms.Label();
            this.LoadExisitingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            this.CreatePrizeLabel.AutoSize = true;
            this.CreatePrizeLabel.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeLabel.Location = new System.Drawing.Point(182, 35);
            this.CreatePrizeLabel.Name = "CreatePrizeLabel";
            this.CreatePrizeLabel.Size = new System.Drawing.Size(408, 50);
            this.CreatePrizeLabel.TabIndex = 30;
            this.CreatePrizeLabel.Text = "Tournament Dashboard";
            // 
            // LoadExisitingTournamentDropdown
            // 
            this.LoadExisitingTournamentDropdown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExisitingTournamentDropdown.FormattingEnabled = true;
            this.LoadExisitingTournamentDropdown.ItemHeight = 37;
            this.LoadExisitingTournamentDropdown.Location = new System.Drawing.Point(157, 189);
            this.LoadExisitingTournamentDropdown.Name = "LoadExisitingTournamentDropdown";
            this.LoadExisitingTournamentDropdown.Size = new System.Drawing.Size(458, 45);
            this.LoadExisitingTournamentDropdown.TabIndex = 32;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(180, 124);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(413, 46);
            this.LoadExistingTournamentLabel.TabIndex = 31;
            this.LoadExistingTournamentLabel.Text = "Load Exisiting Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoadTournamentButton.Location = new System.Drawing.Point(270, 270);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(233, 48);
            this.LoadTournamentButton.TabIndex = 33;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(233, 352);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(307, 93);
            this.CreateTournamentButton.TabIndex = 39;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashbourdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 525);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExisitingTournamentDropdown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.CreatePrizeLabel);
            this.Name = "TournamentDashbourdForm";
            this.Text = "Tournament Dashbourd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CreatePrizeLabel;
        private ComboBox LoadExisitingTournamentDropdown;
        private Label LoadExistingTournamentLabel;
        public Button LoadTournamentButton;
        public Button CreateTournamentButton;
    }
}