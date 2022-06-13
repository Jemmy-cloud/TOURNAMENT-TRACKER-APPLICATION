using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{


    /// <summary>
    /// Represents one tournament.
    /// </summary>
    public class TournamentModel
    {

        /// <summary>
        /// the Unique Identifier for the Tournament
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Tournament specific name.
        /// </summary>

        public string TournamentName { get; set; }
        /// <summary>
        /// Entry fee for current tournament.
        /// </summary>

        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams that joined the tournament.
        /// </summary>

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prizes of tournament.
        /// </summary>

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// set of rounds in tournament.
        /// </summary>

        public List<List<MatchupModels>> Rounds { get; set; } = new List<List<MatchupModels>>();


    }
}
