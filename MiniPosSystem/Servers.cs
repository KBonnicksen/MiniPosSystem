using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPosSystem
{
    /// <summary>
    /// Represents an individual server
    /// </summary>
    public class Servers
    {
        /// <summary>
        /// The unique Id of the server
        /// </summary>
        [Key]
        public int ServerId { get; set; }

        /// <summary>
        /// The legal first name of the server
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal last name of the server
        /// </summary>
        public string LastName { get; set; }
    }
}
