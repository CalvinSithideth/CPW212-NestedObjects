using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsSample
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    class Student
    {
        private string _fullName;
        private string _emailAddress;

        public Student(string fullname)
        {
            FullName = fullname;
        }

        /// <summary>
        /// The lagal first and last
        /// ex. J Doe
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FullName cannot be null or whitespace");
                }
                _fullName = value;
            }
        }

        /// <summary>
        /// The student's school provided email address
        /// </summary>
        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                // Maybe use REGEX for more strict validation
                if (value.EndsWith("@student.cptc.edu"))
                {
                    _emailAddress = value;
                }
                else
                {
                    throw new ArgumentException("Email must end with @student.cptc.edu");
                }
            }
        }

        /// <summary>
        /// The student's mailing address
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// The student's Home phone number
        /// </summary>
        public string Phone { get; set; }
    }
}
