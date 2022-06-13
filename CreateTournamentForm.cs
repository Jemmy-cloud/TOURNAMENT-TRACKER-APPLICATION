using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();  
        List<PrizeModel>selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;
           SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournamentsTeamsListBox.DataSource = null;
           TournamentsTeamsListBox.DataSource = selectedTeams;
            TournamentsTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
           
                TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

                if ( t != null)
                {
                    availableTeams.Remove(t);
                    selectedTeams.Add(t);
                    WireUpLists();

                
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee); 

            if ( !feeAcceptable )
            {
                MessageBox.Show("You need to Enter a valid entry fee!", "Invalid Fee!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
       

            // Create Tournament Entry
            // Create all of the prizes entries
            // Create all of the Team Entries
        }
    }
}
