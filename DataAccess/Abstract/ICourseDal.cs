﻿using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course baseEntity);
        List<Course> GetAll();
    }
}
