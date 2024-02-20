using Kodlama.io.Business;
using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.DataAccess.Concrete;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kurs girmek istiyorsanız 1 kursları getirmek isiyorsanız 2 yazınız");
            int x = Convert.ToInt32(Console.ReadLine());
            Course course = new Course();
            List<Course> list = new List<Course>();
            CourseManager courseManager = new CourseManager(new EfCourseDal());

            if (x == 1)
            {
                Console.WriteLine("Kurs ismi giriniz:");
                course.Name = Console.ReadLine();
                Console.WriteLine("Kurs yılı giriniz:");
                course.Year = Convert.ToInt32(Console.ReadLine());
                courseManager.AddCourse(course);
            }
            else if(x == 2)
            {
                list = courseManager.GetCourses();
                foreach  (var courses in list)
                {
                    Console.WriteLine("Kurs isimleri: {0}", courses.Name);
                }
                Console.Read();
            }



        }
    }
}
