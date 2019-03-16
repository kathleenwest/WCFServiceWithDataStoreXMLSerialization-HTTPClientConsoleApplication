using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchoolService
{
    /// <summary>
    /// PersonList
    /// A special collection of multiple Person
    /// objects into a type of List<Person> object
    /// </summary>
    [CollectionDataContract]
    public class PersonList : List<Person>
    {
        /// <summary>
        /// Default constructor for the object
        /// </summary>
        public PersonList() { }

        /// <summary>
        /// Parameterized constructor for the object
        /// </summary>
        /// <param name="source"> List to initialize the object</param>
        public PersonList(IEnumerable<Person> source) : base(source)
        {

        } // end of method

    } // end of class
} // end of namespace