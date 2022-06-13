using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    public class PrizeModel
    {
        /// <summary>
        /// the Unique Identifier for the Prize
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// team who won place number.
        /// </summary>

        public int PlaceNumber { get; set; }
        /// <summary>
        /// Team who won place name
        /// </summary>
        
        public string  PlaceName { get; set; }
        /// <summary>
        /// exact ammount of money rewarded
        /// </summary>

        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// percentage of prize achieved.
        /// </summary>
        
        public double PricePercentage { get; set; }

        public PrizeModel(String placeName, String placeNumber, String prizeAmount, String pricePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue  = 0;
            int.TryParse(placeNumber, out placeNumberValue);

            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);

            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(pricePercentage, out prizePercentageValue);   

            PricePercentage = prizePercentageValue;
        }

        public PrizeModel()
        {
        }
    }
    
}
