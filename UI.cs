using System;
using System.Collections.Generic;
using System.Linq;
using CivSem1Challenge2_RegistrationSystem.helpers;
using CivSem1Challenge2_RegistrationSystem.models;

namespace CivSem1Challenge2_RegistrationSystem
{
    public class UI
    {
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
        public UI() {
            DataHandler dh = new DataHandler();
            this.Courses = dh.GetCourses();
            this.Students = dh.GetStudents();
            TopMenu();
        }

        public void TopMenu() {
            Console.WriteLine("Welcome to Dod&Gy Student Reg system - Alpha ver");

            Console.WriteLine("1. Print the names and courseNo of the courses");
            Console.WriteLine("2. Get the number of students from course given CourseNo");
            Console.WriteLine("3. Print the name of a student");
            Console.WriteLine("4. Print amount of students in the system");
            Console.WriteLine("5. Print number of students enrolled into valid courses");
            Console.WriteLine("6. Print Add a student");
            Console.WriteLine("7. Print all students who first registered on a given year and a doing a given course");
            Console.WriteLine("8. (optional) Print a list of students NOT enrolled into valid courses");
            Console.WriteLine("9. (optional) Print the oldest student - StudentNo");
            Console.WriteLine("10. (optional) Write the current state of the system back to csv files (save)");
            System.Console.WriteLine("x. Exit");

            var input = Console.ReadLine();

            switch(input) {

                case "1":
                    //TODO: from the attribute this.Courses, print the courseNo and names of all of the courses
                    // use GetCourseDetails to do this
                    // For every value within Courses, display the string output from courses using the get course detail method
                     foreach (var course in Courses)
                    {
                        System.Console.WriteLine(course.GetCourseDetails());
                    }    
                     
                    //----------
                    break;
                
                case "2":
                      System.Console.WriteLine("Please enter the course number");
                    int num;
                    while(!int.TryParse(Console.ReadLine(), out num)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }
                
                    int numStudents = this.GetNumStudents(num);
                    if(numStudents == -1) {
                        System.Console.WriteLine($"Course {num} doesn't exist");
                        break;
                    }
                    System.Console.WriteLine($"Course {num} has {numStudents} students");
                    break;

                case "3":
                    System.Console.WriteLine("Please enter a student number");
                    while(!int.TryParse(Console.ReadLine(), out num)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }

                    string studentName = this.GetStudentName(num);
                    if(studentName == null) {
                        System.Console.WriteLine($"Student {num} doesn't exist");
                        break;
                    }
                    System.Console.WriteLine($"StudentNo: {num} Name: {studentName}");
                    break;

                case "4":
                    //TODO: Print the amount of students in the system
                    // Create and call a method/function named GetNumStudents() to do this.
                    // Took me a while to find where to make it, kept getting errors?? 
                    // Through calling a function, the program executes the code block from there, here
                    System.Console.WriteLine(GetNumStudents());
                    break;

                case "5":
                    //TODO: Print the number of students enrolled in valid courses
                    // When in doubt, make a new function
                  DateTimeOffset 
                    
                    break;

                case "6":
                   //TODO: Add a student to the student List. Then add that student to a valid course
                   this.AddStudent();
                   break;

                case "7":
                    //TODO: Print all students who first registered on a given year and a doing a given course
                    System.Console.WriteLine("Please enter a year");
                    while(!int.TryParse(Console.ReadLine(), out num)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }

                    int courseNum;
                    System.Console.WriteLine("Please enter the course number");
                    while(!int.TryParse(Console.ReadLine(), out courseNum)) {
                        System.Console.WriteLine("Invalid, enter again");
                    }

                    //TODO: print the students who first registered in year num and are doing course courseNum

                    break;

                case "8":
                    //TODO: (optional CREDIT TASK) - Print a list of students who are not enrolled in a valid courses
                    // create a method/function called GetUnenrolledStudents to do this
                    break;

                case "9":
                    //TODO: (optional DISTINCTION TASK) - Print the oldest student's studentno
                    break;

                case "10":
                    //TODO: (optional HIGH DISTINCTION TASK) - Write the current state of the system back to the csv files.
                    // add a method to the DataHandler class to do this
                    break;

                case "x":
                    System.Console.WriteLine("Bye bye");
                    return;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            this.TopMenu();



            
        }


        //TODO: create the GetNumStudents method/function here
        private int GetNumStudents(){
            return this.Students.Count;
        }


private int GetEnrolledStudents(){
             // for loop; for each course in the Courses subsection, find the total 'count' of the items in the list, return that total.
            int total = 0;
            foreach (var course in Courses)
            {
                total += course.Enrolments.Count();
            }
            return total;
    }
        //---------------------

        private string GetStudentName(int num)
        {
            //TODO: write code find the relevant student in Students and return the student's first name and surname
            // if num doesn't exist in Students, return null;
            // should use the method GetFullName() from Student/Person to get the name
             string studentVal = null;
            // i understood it this time around, like task 1, you borrow from a pre existing function, all I had to do was use a for loop again and say, if the student number is 
            // the same as the input, then give the full name instead of increments.
            
            foreach(var student in this.Students)
            
            {

                if(student.StudentNo == num)
                {
                    studentVal = student.GetFullName();
                    break;
                }
            }
            
            return studentVal;
        }
            

        

        private int GetNumStudents(int num)
        {
            //TODO: write code find the relevant courseNo in Courses and return the number of students/enrolments
            // if num doesn't exist in Courses, return -1
            return -1;
                


        }

        private void AddStudent()
        {
            string fname;
            string sname;
            int yob;
            int mob;
            int dob;
            int sno;
            int fyor;

            int courseno;

            System.Console.Write("Please enter student's first name: ");
            fname = Console.ReadLine();
            System.Console.Write("Please enter student's surname: ");
            sname = Console.ReadLine();

            System.Console.Write("Please enter student's year of birth: ");
            while(!int.TryParse(Console.ReadLine(), out yob)) {
                System.Console.WriteLine("Invalid, enter again");
            }

            System.Console.Write("Please enter student's month of birth: ");
            while(!int.TryParse(Console.ReadLine(), out mob)) {
                System.Console.WriteLine("Invalid, enter again");
            }

            System.Console.Write("Please enter student's date of birth: ");
            while(!int.TryParse(Console.ReadLine(), out dob)) {
                System.Console.WriteLine("Invalid, enter again");
            }

            System.Console.Write("Please enter student's id/number: ");
            while(!int.TryParse(Console.ReadLine(), out sno)) {
                System.Console.WriteLine("Invalid, enter again");
            }

            System.Console.Write("Please enter student's first year of registration: ");
            while(!int.TryParse(Console.ReadLine(), out fyor)) {
                System.Console.WriteLine("Invalid, enter again");
            }

            //TODO: add student to the this.StudentList

            System.Console.Write("Enter course number to add the student to: ");
            //TODO: add the student to the desired course in this.Courses.  
            //      If the course doesn't exist let the user know and go back to the main menu.
            // -----------------------
            // (optional - CREDIT TASK)  If the course doesn't exist keep asking until a valid course is entered.
            //                           User may enter 0000 for no course to be enrolled into

        }

        //TODO: Create the GetUnerolledStudents method/function here

    }
}