using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// the Unique Identifier for the Prize
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// First Name of the Person.
        /// </summary>

        public String FirstName { get; set; }
        /// <summary>
        /// Last Name of the Person.
        /// </summary>
        
        public String LastName { get; set; }
        /// <summary>
        /// Email address of the Person.
        /// </summary>
        
        public String EmailAddress { get; set; }
        /// <summary>
        /// Phone Number of the Person.
        /// </summary>
       
        public String CellphoneNumber { get; set; }

        public string FullName
        {
            get { 
                return $"{FirstName} {LastName}";
            }
        }
    }
}
