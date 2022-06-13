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
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();


        public CreateTeamForm()
        {
            InitializeComponent();

           // CreateSampleData();
            
            WireUpLists();
        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Jim", LastName = " Stone" });
            availableTeamMembers.Add(new PersonModel { FirstName = "John", LastName = " Miller" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = " Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Judie", LastName = " Kevin" });

        }

        private void WireUpLists()
        {

            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm ())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.CellphoneNumber = CellphoneValue.Text;

                 p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

                FirstNameValue.Text = "";
                LastNameLabel.Text = "";
                EmailValue.Text = "";
                CellphoneValue.Text = "";


            }
            else
            {
                MessageBox.Show("You need to fill in all the fields!");
            }
        }
        private bool ValidateForm( )
        {
            // TODO - Add validation to the form

            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (EmailValue.Text.Length == 0)
            {
                return false;
            }

            if (CellphoneValue.Text.Length == 0)
            {
                return false;
            }



            return true;
        }

        private void TournamentsPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpLists();

    }
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists(); 
            }

        }

        private void selectTeamMembersDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();
            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;
            t = GlobalConfig.Connection.CreateTeam(t);
        }
    }
}
