using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a individual college student. 
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The assigned school email address.
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// The Date of Birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Preferred Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Advisor assigned to student
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
