using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchoolService
{
    /// <summary>
    /// Student:
    /// Type of Person
    /// identifies by string id, major, units, and gpa
    /// </summary>
    [DataContract]
    public class Student : Person
    {
        /// <summary>
        /// Student’s alpha-numeric ID
        /// </summary>
        [DataMember]
        public string ID { get; set; }

        /// <summary>
        /// Student’s major
        /// </summary>
        [DataMember]
        public string Major { get; set; }

        /// <summary>
        /// Number of units the student has completed
        /// </summary>
        [DataMember]
        public float Units { get; set; }

        /// <summary>
        /// Student’s GPA
        /// </summary>
        [DataMember]
        public float GPA { get; set; }

    } // end of class
} // end of namespace