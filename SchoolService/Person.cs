using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchoolService
{
    /// <summary>
    /// Person
    /// Describes a human person with a last name,
    /// first name, dat of birth, and gender
    /// Student and Teacher objects are known types
    /// that inherit from this class
    /// </summary>
    [DataContract]
    [KnownType(typeof(Student))]
    [KnownType(typeof(Teacher))]
    public class Person
    {
        /// <summary>
        /// Person’s last name
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Person’s first name
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [DataMember]
        public DateTime DOB { get; set; }

        /// <summary>
        /// Person’s gender
        /// </summary>
        [DataMember]
        public GenderEnum Gender { get; set; }

    } //end of class
} // end of namespace