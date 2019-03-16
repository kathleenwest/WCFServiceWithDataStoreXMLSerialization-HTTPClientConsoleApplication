using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;

namespace SchoolService
{
    /// <summary>
    /// Implementation of the School Service Contract
    /// </summary>
	public class SchoolService : ISchoolService
	{
        /// <summary>
        /// AddStudent
        /// Accepts all necessary values to create a new Student object
        /// </summary>
        /// <param name="lastName">(string) last name of the Person</param>
        /// <param name="firstName">(string) first name of the Person</param>
        /// <param name="dob">(DateTime) date of birth of the Person</param>
        /// <param name="gender">(GenderEnum) gender of the Person</param>
        /// <param name="id">(string) identifier of the Person</param>
        /// <param name="major">(string) major of the Student</param>
        /// <param name="units">(float) completed units of the Student</param>
        /// <param name="gpa">(float) GPA of the student</param>
        /// <returns>Student object</returns>
        public Student AddStudent(string lastName, string firstName, DateTime dob, GenderEnum gender, string id, string major, float units, float gpa)
		{
			PersonList data = DataStore.LoadData(); 
			Student result = null;
			Student student = GetStudent(id);
			if (student == null)
			{
				// Student doesn't exist
				result = new Student() { ID = id, LastName = lastName, FirstName = firstName,
					DOB = dob, Gender = gender, Major = major, Units = units, GPA = gpa	};
				data.Add(result);
				DataStore.SaveData();
			}
			return result;
		} // end of method

        /// <summary>
        /// DeleteStudent
        /// Finds a Student by the Person ID and deletes the object
        /// </summary>
        /// <param name="id">(string) identifier of the Person</param>
		public void DeleteStudent(string id)
		{
			PersonList data = DataStore.LoadData();
			data.RemoveAll(person => person is Student && (person as Student).ID == id);
			DataStore.SaveData();
		} // end of method

        /// <summary>
        /// GetStudent
        /// Finds and returns the Student by the Person ID
        /// </summary>
        /// <param name="id">(string) identifier of the Person</param>
        /// <returns>(Student) student object</returns>
		public Student GetStudent(string id)
		{
			PersonList data = DataStore.LoadData();
			var query = from person in data
						let student = person as Student
						where student != null && student.ID == id
						select student;
			return query.FirstOrDefault();
		} // end of method

        /// <summary>
        /// GetStudents
        /// Finds all the Student objects and
        /// returns them as an enumerable object
        /// holding all the students
        /// </summary>
        /// <returns>List<Student> list of student objects</returns>
		public List<Student> GetStudents()
		{
			PersonList data = DataStore.LoadData();
			var query = from person in data
						let student = person as Student
						where student != null
						select student;
			return query.ToList();
		} // end of method

        /// <summary>
        /// UpdateStudent
        /// Accepts values corresponding to all Student properties
        /// First Deletes the student and then adds a new student with
        /// the given parameters. Only affects the First of Default
        /// Student ID object that matches the input parameter.
        /// </summary>
        /// <param name="lastName">(string) last name of the Person</param>
        /// <param name="firstName">(string) first name of the Person</param>
        /// <param name="dob">(DateTime) date of birth of the Person</param>
        /// <param name="gender">(GenderEnum) gender of the Person</param>
        /// <param name="id">(string) identifier of the Person</param>
        /// <param name="major">(string) major of the Student</param>
        /// <param name="units">(float) completed units of the Student</param>
        /// <param name="gpa">(float) GPA of the student</param>
        /// <returns>(Student) student that was deleted and then added (updated)</returns>
        public Student UpdateStudent(string lastName, string firstName, DateTime dob, GenderEnum gender, string id, string major, float units, float gpa)
		{
			// Simplest technique is to remove then add
			DeleteStudent(id);
			return AddStudent(lastName, firstName, dob, gender, id, major, units, gpa);
		} // end of method

        /// <summary>
        /// GetPeople
        /// Returns a collection object representing a List<Person>
        /// that is a list of Person objects with the last name
        /// and first name provided
        /// </summary>
        /// <param name="lastName">(string) last name of the Person</param>
        /// <param name="firstName">(string) first name of the Person</param>
        /// <returns>(PersonList) collection of people with the first and last name specified
        /// as an input parameter</returns>
		public PersonList GetPeople(string lastName, string firstName)
		{
			PersonList data = DataStore.LoadData();
			var query = data.AsQueryable();
			if (!string.IsNullOrEmpty(lastName))
			{
				query = query.Where(p => p.LastName == lastName);
			}
			if (!string.IsNullOrEmpty(firstName))
			{
				query = query.Where(p => p.FirstName == firstName);
			}
			return new PersonList(query);
		} // end of method

        /// <summary>
        /// AddTeacher
        /// Accepts all necessary values to create a new Teacher object
        /// </summary>
        /// <param name="lastName">(string) last name of the Person</param>
        /// <param name="firstName">(string) first name of the Person</param>
        /// <param name="dob">(DateTime) date of birth of the Person</param>
        /// <param name="gender">(GenderEnum) gender of the Person</param>
        /// <param name="id">(int) identifier of the Teacher</param>
        /// <param name="dateofhire">(DateTine) date of hire of the Teacher</param>
        /// <param name="salary">(int) salary of the Teacher</param>
        /// <returns>(Teacher) teacher object</returns>
        public Teacher AddTeacher(string lastName, string firstName, DateTime dob, GenderEnum gender, int idTeacher, DateTime dateofhire, int salary)
        {
            PersonList data = DataStore.LoadData();
            Teacher result = null;
            Teacher teacher = GetTeacher(idTeacher);
            if (teacher == null)
            {
                // Teacher doesn't exist, object initialize Teacher
                result = new Teacher() 
                {
                    LastName = lastName,
                    FirstName = firstName,
                    DOB = dob,
                    Gender = gender,
                    ID = idTeacher,
                    DateOfHire = dateofhire,
                    Salary = salary
                };
                data.Add(result);
                DataStore.SaveData();
            } // end of if
            return result; 
        } // end of method

        /// <summary>
        /// DeleteTeacher
        /// Deletes a Teacher object by its Teacher ID
        /// </summary>
        /// <param name="id">(int) identifier of the Teacher</param>
        public void DeleteTeacher(int id)
        {
            PersonList data = DataStore.LoadData();
            data.RemoveAll(person => person is Teacher && (person as Teacher).ID == id);
            DataStore.SaveData();
        } // end of method

        /// <summary>
        /// GetTeacher
        /// Gets a Teacher object by its Teacher ID
        /// </summary>
        /// <param name="id">(int) identifier of the Teacher</param>
        /// <returns>(Teacher) teacher object</returns>
        public Teacher GetTeacher(int id)
        {
            PersonList data = DataStore.LoadData();
            var query = from person in data
                        let teacher = person as Teacher
                        where teacher != null && teacher.ID == id
                        select teacher;
            return query.FirstOrDefault();
        } // end of method

        /// <summary>
        /// GetTeachers()
        /// Returns a list of Teacher objects
        /// </summary>
        /// <returns>(List<Teacher>) teachers</returns>
        public List<Teacher> GetTeachers()
        {
            PersonList data = DataStore.LoadData();
            var query = from person in data
                        let teacher = person as Teacher
                        where teacher != null
                        select teacher;
            return query.ToList();
        } // end of method

        /// <summary>
        /// UpdateTeacher
        /// First deletes, then adds a new Teacher
        /// object with a unique Teacher ID that is first
        /// or default in the data store
        /// </summary>
        /// <param name="lastName">(string) last name of the Person</param>
        /// <param name="firstName">(string) first name of the Person</param>
        /// <param name="dob">(DateTime) date of birth of the Person</param>
        /// <param name="gender">(GenderEnum) gender of the Person</param>
        /// <param name="id">(int) identifier of the Teacher</param>
        /// <param name="dateofhire">(DateTine) date of hire of the Teacher</param>
        /// <param name="salary">(int) salary of the Teacher</param>
        /// <returns>(Teacher) teacher object</returns>
        public Teacher UpdateTeacher(string lastName, string firstName, DateTime dob, GenderEnum gender, int id, DateTime dateofhire, int salary)
        {
            // Simplest technique is to remove then add
            DeleteTeacher(id);
            return AddTeacher(lastName, firstName, dob, gender, id, dateofhire, salary);
        } // end of method

    } // end of class
} // end of namespace
