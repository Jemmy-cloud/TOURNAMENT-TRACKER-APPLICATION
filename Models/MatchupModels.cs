using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModels
    {
        /// <summary>
        /// the set of teams that were involved in the match.
        /// </summary>
        
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// the winner of the match
        /// </summary>
       
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is part of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
