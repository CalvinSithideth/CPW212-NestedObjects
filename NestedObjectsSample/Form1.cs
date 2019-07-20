using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedObjectsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Instructor> instructors = new List<Instructor>();

            PopulateInstructorTestData(instructors);

            LstInstructors.DataSource = instructors;
            LstInstructors.DisplayMember = nameof(Instructor.FullName); // Instead of using string "FullName"
        }

        private void PopulateInstructorTestData(List<Instructor> instructors)
        {
            Instructor instructorKen = new Instructor()
            { // Object initialization
                Email = "Ken@cptc.edu",
                FullName = "Dr. Kenneth Meerdink"
            };

            List<Course> kenCourses = new List<Course>()
            {
                new Course()
                { // Nested object initialization
                    Title = "Data Structures",
                    CourseNumber = "CPW 245",
                    Roster = new List<Student>()
                    {
                        new Student("Dennis Reynolds"),
                        new Student("Frank Reynolds")
                    }
                },
                new Course()
                {
                    Title = "Java II",
                    CourseNumber = "CPW 143",
                    Roster = new List<Student>()
                    {
                        new Student("Charlie Kelly")
                    }
                }
            };

            instructorKen.CourseLoad = kenCourses;

            instructors.Add(instructorKen);
        }

        private void LstInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor currInstructor = LstInstructors.SelectedItem as Instructor;

            //List<Course> courses = currInstructor.CourseLoad;

            LstCourses.DataSource = currInstructor.CourseLoad;
            // Display member must be a single property
            LstCourses.DisplayMember = nameof(Course.CourseDisplay);
        }

        private void LstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstCourses.SelectedIndex < 0)
            {
                return;
            }

            Course selectedCourse = LstCourses.SelectedItem as Course;

            LstStudents.DataSource = selectedCourse.Roster;
            LstStudents.DisplayMember = nameof(Student.FullName);
        }
    }
}
