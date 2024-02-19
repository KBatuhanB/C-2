using Main.Business.Abstract;
using Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Business.Concretes
{
    public class CourseManager:IManager<Course>
    {
        List<Course> courses;
        public CourseManager()
        {
            Course course1 = new Course();
            course1.CourseId = 1;
            course1.CourseName = "JavaScript";
            course1.CourseDescription = "Learn JAvaScript";

            Course course2 = new Course();
            course2.CourseId = 2;
            course2.CourseName = "Python";
            course2.CourseDescription = "Learn Python";

            courses = new List<Course>{course1, course2};
        }
        public List<Course> GetAll()
        {
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
        public void Remove(Course course)
        {
            courses.Remove(course);
        }
    }
}
