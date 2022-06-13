namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentsTeamsListBox = new System.Windows.Forms.ListBox();
            this.TournamentsPlayersLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayerButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPriceButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 24);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(403, 62);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameValue.Location = new System.Drawing.Point(33, 167);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(350, 43);
            this.TournamentNameValue.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentNameLabel.Location = new System.Drawing.Point(33, 118);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(290, 45);
            this.TournamentNameLabel.TabIndex = 9;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeValue.Location = new System.Drawing.Point(197, 236);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(134, 43);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EntryFeeLabel.Location = new System.Drawing.Point(33, 233);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(153, 45);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.ItemHeight = 37;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(33, 375);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(350, 45);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(33, 311);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(191, 45);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLabel
            // 
            this.CreateNewTeamLabel.AutoSize = true;
            this.CreateNewTeamLabel.Location = new System.Drawing.Point(299, 319);
            this.CreateNewTeamLabel.Name = "CreateNewTeamLabel";
            this.CreateNewTeamLabel.Size = new System.Drawing.Size(156, 38);
            this.CreateNewTeamLabel.TabIndex = 15;
            this.CreateNewTeamLabel.TabStop = true;
            this.CreateNewTeamLabel.Text = "Create new";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddTeamButton.Location = new System.Drawing.Point(88, 435);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(229, 69);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeButton.Location = new System.Drawing.Point(88, 525);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(229, 69);
            this.CreatePrizeButton.TabIndex = 17;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentsTeamsListBox
            // 
            this.TournamentsTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentsTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentsTeamsListBox.FormattingEnabled = true;
            this.TournamentsTeamsListBox.ItemHeight = 31;
            this.TournamentsTeamsListBox.Location = new System.Drawing.Point(488, 167);
            this.TournamentsTeamsListBox.Name = "TournamentsTeamsListBox";
            this.TournamentsTeamsListBox.Size = new System.Drawing.Size(344, 188);
            this.TournamentsTeamsListBox.TabIndex = 18;
            // 
            // TournamentsPlayersLabel
            // 
            this.TournamentsPlayersLabel.AutoSize = true;
            this.TournamentsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentsPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentsPlayersLabel.Location = new System.Drawing.Point(488, 118);
            this.TournamentsPlayersLabel.Name = "TournamentsPlayersLabel";
            this.TournamentsPlayersLabel.Size = new System.Drawing.Size(228, 45);
            this.TournamentsPlayersLabel.TabIndex = 19;
            this.TournamentsPlayersLabel.Text = "Team / Players";
            // 
            // DeleteSelectedPlayerButton
            // 
            this.DeleteSelectedPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedPlayerButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedPlayerButton.Location = new System.Drawing.Point(873, 484);
            this.DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            this.DeleteSelectedPlayerButton.Size = new System.Drawing.Size(186, 97);
            this.DeleteSelectedPlayerButton.TabIndex = 20;
            this.DeleteSelectedPlayerButton.Text = "Delete Selected";
            this.DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPriceButton
            // 
            this.DeleteSelectedPriceButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPriceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPriceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPriceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedPriceButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedPriceButton.Location = new System.Drawing.Point(873, 210);
            this.DeleteSelectedPriceButton.Name = "DeleteSelectedPriceButton";
            this.DeleteSelectedPriceButton.Size = new System.Drawing.Size(186, 97);
            this.DeleteSelectedPriceButton.TabIndex = 23;
            this.DeleteSelectedPriceButton.Text = "Delete Selected";
            this.DeleteSelectedPriceButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizesLabel.Location = new System.Drawing.Point(488, 386);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(103, 45);
            this.PrizesLabel.TabIndex = 22;
            this.PrizesLabel.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 31;
            this.PrizesListBox.Location = new System.Drawing.Point(488, 435);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(344, 188);
            this.PrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(384, 643);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(307, 93);
            this.CreateTournamentButton.TabIndex = 24;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 766);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPriceButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayerButton);
            this.Controls.Add(this.TournamentsPlayersLabel);
            this.Controls.Add(this.TournamentsTeamsListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private TextBox TournamentNameValue;
        private Label TournamentNameLabel;
        private TextBox EntryFeeValue;
        private Label EntryFeeLabel;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLabel;
        public Button AddTeamButton;
        public Button CreatePrizeButton;
        private ListBox TournamentsPlayersListBox;
        private Label TournamentsPlayersLabel;
        public Button DeleteSelectedPlayerButton;
        public Button DeleteSelectedPriceButton;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        public Button CreateTournamentButton;
        private ListBox TournamentsTeamsListBox;
    }
}