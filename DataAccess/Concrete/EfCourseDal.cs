using Kodlama.io.DataAccess.Abstract;
using Kodlama.io.DataAccess.Concrete.Contexts;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Concrete
{
    public class EfCourseDal : ICourseDal
    {
        KodlamaDb kodlamaDb = new KodlamaDb();
        public void Add(Course courseEntity)
        {
            kodlamaDb.Entry(courseEntity);
            kodlamaDb.Add(courseEntity);
            kodlamaDb.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return kodlamaDb.Courses.ToList();
        }
    }
}
