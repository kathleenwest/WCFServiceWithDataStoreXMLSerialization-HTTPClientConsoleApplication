using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClient.SchoolServiceRef;
using HttpClient.MathServiceRef;

namespace HttpClient
{
    /// <summary>
    /// Test Console Application
    /// Demonstrate the default Http client
    /// proxy access to the School Service host
    /// and also the Math Service host
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main entry method for the Program
        /// </summary>
        /// <param name="args">No command line arguments used</param>
        static void Main(string[] args)
        {
            // Creates Proxy to School Service
            SchoolServiceClient proxy = new SchoolServiceClient();

            #region Student Test
            // Student Test
            Console.WriteLine(new string('=', 24));
            Console.WriteLine("= Student Service Test =");
            Console.WriteLine(new string('=', 24));

            Console.WriteLine();
            Console.WriteLine("Adding new students...");
            Console.WriteLine();

            Student newStudent = proxy.AddStudent("Smith", "Bill", DateTime.Parse("2/3/1977"), GenderEnum.Male, "A123456", "Communication", 33f, 3.5f);
            newStudent = proxy.AddStudent("Williams", "Bill", DateTime.Parse("1/3/1988"), GenderEnum.Male, "B435345", "Computer Science", 31f, 2.5f);
            newStudent = proxy.AddStudent("Francis", "Jill", DateTime.Parse("8/8/1982"), GenderEnum.Female, "D777666", "Math", 22f, 3.9f);
            newStudent = proxy.AddStudent("West", "Kathleen", DateTime.Parse("1/19/1981"), GenderEnum.Female, "D777777", "C# Programming", 25f, 4.0f);
            newStudent = proxy.AddStudent("West", "Jared", DateTime.Parse("9/18/1978"), GenderEnum.Male, "D777778", "Graphic Design", 33f, 2.9f);
            newStudent = proxy.AddStudent("West", "KathieOpps", DateTime.Parse("11/01/2018"), GenderEnum.Unknown, "D777779", "Forgetfullness", 1f, 1.9f);
            List<Student> students = proxy.GetStudents();

            PrintStudents(students);

            Console.WriteLine();
            Console.WriteLine("Getting Student D777779...");
            Console.WriteLine();

            Student student = proxy.GetStudent("D777779");

            PrintPerson(student);

            Console.WriteLine();
            Console.WriteLine("Updating Student D777779...");
            Console.WriteLine();

            student = proxy.UpdateStudent("West", "Kathleen", DateTime.Parse("01/19/1981"), GenderEnum.Female, "D777779", "Electrical Engineering", 150f, 3.3f);

            PrintPerson(student);

            Console.WriteLine();
            Console.WriteLine("Deleting Student D777779...");
            Console.WriteLine();

            proxy.DeleteStudent("D777779");

            students = proxy.GetStudents();
            PrintStudents(students);

            #endregion Student Test

            #region Teacher Test
            // Student Test
            Console.WriteLine(new string('=', 24));
            Console.WriteLine("= Teacher Service Test =");
            Console.WriteLine(new string('=', 24));

            Console.WriteLine();
            Console.WriteLine("Adding new teachers...");
            Console.WriteLine();

            Teacher newTeacher = proxy.AddTeacher("Smith", "Bill", DateTime.Parse("2/3/1977"), GenderEnum.Male, 1111111, DateTime.Parse("1/1/2018"), 25000);
            newTeacher = proxy.AddTeacher("Williams", "Bill", DateTime.Parse("1/3/1988"), GenderEnum.Male, 2111111, DateTime.Parse("2/1/2018"), 35000);
            newTeacher = proxy.AddTeacher("Francis", "Jill", DateTime.Parse("8/8/1982"), GenderEnum.Female, 3111111, DateTime.Parse("3/1/2018"), 45000);
            newTeacher = proxy.AddTeacher("West", "Kathleen", DateTime.Parse("1/19/1981"), GenderEnum.Female, 4111111, DateTime.Parse("4/1/2018"), 95000);
            newTeacher = proxy.AddTeacher("West", "Jared", DateTime.Parse("9/18/1978"), GenderEnum.Male, 5111111, DateTime.Parse("5/1/2018"), 75000);
            newTeacher = proxy.AddTeacher("West", "Kathleen", DateTime.Parse("01/19/1981"), GenderEnum.Female, 6111111, DateTime.Parse("6/1/2018"), 1000);
            List<Teacher> teachers = proxy.GetTeachers();

            PrintTeachers(teachers);

            Console.WriteLine();
            Console.WriteLine("Getting Teacher 6111111...");
            Console.WriteLine();

            Teacher teacher = proxy.GetTeacher(6111111);

            PrintPerson(teacher);

            Console.WriteLine();
            Console.WriteLine("Updating Teacher 6111111...");
            Console.WriteLine();

            teacher = proxy.UpdateTeacher("West", "KathieOpps", DateTime.Parse("11/01/2018"), GenderEnum.Unknown, 6111111, DateTime.Parse("6/1/2018"), 5000);

            PrintPerson(teacher);

            Console.WriteLine();
            Console.WriteLine("Deleting Teacher 6111111...");
            Console.WriteLine();

            proxy.DeleteTeacher(6111111);

            teachers = proxy.GetTeachers();
            PrintTeachers(teachers);

            #endregion Teacher Test

            #region People Test
            // People Test
            Console.WriteLine(new string('=', 23));
            Console.WriteLine("= People Service Test =");
            Console.WriteLine(new string('=', 23));

            Console.WriteLine();
            Console.WriteLine("Getting people Kathleen West...");
            Console.WriteLine();

            PersonList people = new PersonList();
            people = proxy.GetPeople("West","Kathleen");

            PrintPeople(people);

            Console.WriteLine();
            Console.WriteLine("Getting people Bill Smith...");
            Console.WriteLine();

            people = proxy.GetPeople("Smith", "Bill");

            PrintPeople(people);

            Console.WriteLine();

            #endregion People Test

            #region Math Service Test

            // Creates Proxy to Math Service 
            MathServiceClient mathproxy = new MathServiceClient();

            // Math Service Operations Test: Add
            Console.WriteLine("====== Math Operations Test ======");
            Console.WriteLine("Adding 12.5 + 2.3");
            double result = mathproxy.Add(12.5, 2.3);
            Console.WriteLine(result);

            // Math Service Operations Test: Subtract
            Console.WriteLine("Subtracting 12.5 - 2.3");
            result = mathproxy.Subtract(12.5, 2.3);
            Console.WriteLine(result);

            // Math Service Operations Test: Multiply
            Console.WriteLine("Multiplying 12.5 * 2.3");
            result = mathproxy.Multiply(12.5, 2.3);
            Console.WriteLine(result);

            // Math Service Operations Test: Divide
            Console.WriteLine("Dividing 12.5 / 2.3");
            result = mathproxy.Divide(12.5, 2.3);
            Console.WriteLine(result);

            // Math Service Operations Test: Circle Area
            Console.WriteLine("====== Circle Area Test ======");
            Console.WriteLine("Area of circle with radius 12.5");
            result = mathproxy.CircleArea(12.5);
            Console.WriteLine(result);
            Console.WriteLine("Area of circle with radius 2.3");
            result = mathproxy.CircleArea(2.3);
            Console.WriteLine(result);

            #endregion Math Service Test

            Console.WriteLine("Press <Enter> to Quit...");
            Console.ReadLine();

        } // end of method

        #region Print Helper Methods

        /// <summary>
        /// PrintPeople
        /// Prints a collection of List<Person>
        /// Also, Prints Student or Teacher properties
        /// </summary>
        /// <param name="people">(PersonList) people, a collection List<People></param>
        private static void PrintPeople(PersonList people)
        {
            // Print List of People
            foreach (Person person in people)
            {
                // If Student - Print Student
                if(person is Student)
                {
                    Console.WriteLine("Student...");
                    List<Student> students = new List<Student> { person as Student };
                    PrintStudents(students);
                }
                else if(person is Teacher)
                {
                    Console.WriteLine("Teacher...");
                    List<Teacher> teachers = new List<Teacher> { person as Teacher };
                    PrintTeachers(teachers);
                }

                else
                {
                    Console.WriteLine("Person...");
                    PrintPerson(person);
                }
            } // end of foreach
        } // end of class

        /// <summary>
        /// PrintStudents
        /// Prints each student with both person and student
        /// attributes 
        /// </summary>
        /// <param name="students">(List<Student>) student list</param>
        private static void PrintStudents(List<Student> students)
        {
            // Print Header for Student
            Console.WriteLine($"{"Last Name",-15} {"First Name",-10} {"Date of Birth",-15} {"ID",-10} {"Major",-20} {"Units",-6} {"GPA",-6}");

            // Print List of Students
            foreach (Student student in students)
            {
                PrintPerson(student);
            }
        }

        /// <summary>
        /// PrintTeachers
        /// Prints each teacher with both person and teacher
        /// attributes 
        /// </summary>
        /// <param name="teachers">(List<Teacher>) teacher list</param>
        private static void PrintTeachers(List<Teacher> teachers)
        {
            // Print Header for Teacher
            Console.WriteLine($"{"Last Name",-15} {"First Name",-10} {"Date of Birth",-15} {"ID",-10} {"Date of Hire",-15} {"Salary",15}");

            // Print List of Teachers
            foreach (Teacher teacher in teachers)
            {
                PrintPerson(teacher);
            }
        }

        /// <summary>
        /// PrintPerson
        /// Prints a person with person only attributes 
        /// </summary>
        /// <param name="person">(Person) a person</param>
        static void PrintPerson(Person person)
        {
            // Print Person Basic Information
            Console.Write($"{person.LastName,-15} {person.FirstName,-10} {person.DOB,-15:yyyy-MM-dd} ");

            // Print Teacher or Student Attributes
            if(person is Student)
            {
                // Person is a Student
                Student student = person as Student;
                // Print Student Fields
                Console.Write($"{student.ID, -10} {student.Major,-20} {student.Units,6:F2} {student.GPA,-6:F2}");
            }
            else if(person is Teacher)
            {
                // Person is a Teacher
                Teacher teacher = person as Teacher;
                // Print Teacher fields
                Console.Write($"{teacher.ID, -10} {teacher.DateOfHire,-15:yyyy-MM-dd} {teacher.Salary,15:C}");
            }

            // Print new line
            Console.WriteLine();

        } // end of method

        #endregion Print Helper Methods

    } // end of class
} // end of namespace
