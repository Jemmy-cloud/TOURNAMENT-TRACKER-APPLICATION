namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreText = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(14, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(271, 62);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentName.Location = new System.Drawing.Point(307, 9);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(189, 62);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundLabel.Location = new System.Drawing.Point(14, 101);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(117, 46);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.ItemHeight = 37;
            this.RoundDropDown.Location = new System.Drawing.Point(166, 101);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(360, 45);
            this.RoundDropDown.TabIndex = 3;
            this.RoundDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UnplayedOnlyCheckbox
            // 
            this.UnplayedOnlyCheckbox.AutoSize = true;
            this.UnplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyCheckbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UnplayedOnlyCheckbox.Location = new System.Drawing.Point(189, 152);
            this.UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            this.UnplayedOnlyCheckbox.Size = new System.Drawing.Size(257, 50);
            this.UnplayedOnlyCheckbox.TabIndex = 4;
            this.UnplayedOnlyCheckbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 31;
            this.matchupListBox.Location = new System.Drawing.Point(48, 227);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(430, 281);
            this.matchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneName.Location = new System.Drawing.Point(605, 238);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(208, 46);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(575, 300);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(104, 46);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreValue.Location = new System.Drawing.Point(709, 303);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(140, 43);
            this.TeamOneScoreValue.TabIndex = 8;
            this.TeamOneScoreValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // TeamTwoScoreText
            // 
            this.TeamTwoScoreText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreText.Location = new System.Drawing.Point(709, 534);
            this.TeamTwoScoreText.Name = "TeamTwoScoreText";
            this.TeamTwoScoreText.Size = new System.Drawing.Size(140, 43);
            this.TeamTwoScoreText.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(575, 531);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(104, 46);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoName.Location = new System.Drawing.Point(605, 462);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(208, 46);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<team two>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.VersusLabel.Location = new System.Drawing.Point(666, 380);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(87, 46);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "-VS-";
            this.VersusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.Location = new System.Drawing.Point(846, 376);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(186, 69);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 648);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.TeamTwoScoreText);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckbox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "TournamentViewerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private Label TournamentName;
        private Label roundLabel;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label TeamOneName;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreText;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoName;
        private Label VersusLabel;
        public Button scoreButton;
    }
}