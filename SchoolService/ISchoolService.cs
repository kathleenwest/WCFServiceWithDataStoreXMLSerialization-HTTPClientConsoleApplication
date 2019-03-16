using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SchoolService
{ 
    /// <summary>
    /// Interface for School Service Contracts
    /// </summary>
    [ServiceContract]
	public interface ISchoolService
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
        [OperationContract]
		Student AddStudent(string lastName, string firstName, DateTime dob, GenderEnum gender, string id, string major, float units, float gpa);

        /// <summary>
        /// DeleteStudent
        /// Finds a Student by the Person ID and deletes the object
        /// </summary>
        /// <param name="id">(string) identifier of the Person</param>
        [OperationContract]
		void DeleteStudent(string id);

        /// <summary>
        /// GetStudent
        /// Finds and returns the Student by the Person ID
        /// </summary>
        /// <param name="id">(string) identifier of the Person</param>
        /// <returns>(Student) student object</returns>
		[OperationContract]
		Student GetStudent(string id);

        /// <summary>
        /// GetStudents
        /// Finds all the Student objects and
        /// returns them as an enumerable object
        /// holding all the students
        /// </summary>
        /// <returns>List<Student> list of student objects</returns>
		[OperationContract]
		List<Student> GetStudents();

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
        [OperationContract]
		Student UpdateStudent(string lastName, string firstName, DateTime dob, GenderEnum gender, string id, string major, float units, float gpa);

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
        [OperationContract]
        Teacher AddTeacher(string lastName, string firstName, DateTime dob, GenderEnum gender, int idTeacher, DateTime dateofhire, int salary);

        /// <summary>
        /// DeleteTeacher
        /// Deletes a Teacher object by its Teacher ID
        /// </summary>
        /// <param name="id">(int) identifier of the Teacher</param>
        [OperationContract]
        void DeleteTeacher(int id);

        /// <summary>
        /// GetTeacher
        /// Gets a Teacher object by its Teacher ID
        /// </summary>
        /// <param name="id">(int) identifier of the Teacher</param>
        /// <returns>(Teacher) teacher object</returns>
        [OperationContract]
        Teacher GetTeacher(int id);

        /// <summary>
        /// GetTeachers()
        /// Returns a list of Teacher objects
        /// </summary>
        /// <returns>(List<Teacher>) teachers</returns>
        [OperationContract]
        List<Teacher> GetTeachers();

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
        [OperationContract]
        Teacher UpdateTeacher(string lastName, string firstName, DateTime dob, GenderEnum gender, int id, DateTime dateofhire, int salary);

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
		[OperationContract]
		PersonList GetPeople(string lastName, string firstName);

	} // end of class
} // end of namespace
