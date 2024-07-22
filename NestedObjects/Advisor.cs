using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// Legal First and Last Name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Employee Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Office Location (Building, Room Number)
        /// </summary>
        public string OfficeLocation { get; set; }

    }
}
