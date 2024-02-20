using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Entities.Concrete
{
    public class Instructor:BaseEntity
    {
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
