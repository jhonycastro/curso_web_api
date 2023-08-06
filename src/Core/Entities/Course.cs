using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Course : Auditable<int>
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<ClassTime> ClassTime { get; set; } = new HashSet<ClassTime>();
        public ICollection<Student> Stidents { get; set; } = new HashSet<Student>();
    }
}
