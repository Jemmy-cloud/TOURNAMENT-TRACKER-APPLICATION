using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team in the Match.
    /// </summary>

    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the Match.
        /// </summary>

        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score of this particular team.
        /// </summary>

        public double Score { get; set; }
        /// <summary>
        /// Represents the match that this team came as a winner
        /// </summary>

        public MatchupModels ParentMatchup { get; set; }


    }
}
