using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Business
{
    public class CourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void AddCourse(Course course)
        {
            course.Year -= 1;
            course.Name += "Kursu";
            _courseDal.Add(course);
        }

        public List<Course> GetCourses()
        {
            return _courseDal.GetAll();
        }
    }
}
