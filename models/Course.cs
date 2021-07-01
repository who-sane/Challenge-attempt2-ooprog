using System.Collections.Generic;

namespace CivSem1Challenge2_RegistrationSystem.models {
    public class Course {
        public string Name { get; set; }

        public int CourseNo { get; set; }
        string[] getCourseDetails = System.IO.File.ReadAllLines(@"C:\Users\103615588\Desktop\Challenge\CivSem1Challenge2-RegistrationSystem\course_data.csv");
        
        
        public List<Student> Enrolments { get; set; }

        public Course (string name, int courseNo) {
            this.Name = name;
            this.CourseNo = courseNo;
            this.Enrolments = new List<Student>();
            string[] enrolments = System.IO.File.ReadAllLines(@"C:\Users\103615588\Desktop\Challenge\CivSem1Challenge2-RegistrationSystem\student_data_mock.csv");
            

        }

        public string GetCourseDetails() {
            string[] getCourseDetails = System.IO.File.ReadAllLines(@"C:\Users\103615588\Desktop\Challenge\CivSem1Challenge2-RegistrationSystem\course_data.csv");
            for (int i = 1; i < getCourseDetails.Length; i++)
            {
            string[] clean=getCourseDetails[i].Split(',');    
            }
            return $"{this.CourseNo}: {this.Name}";
        }
    }
}