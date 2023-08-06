using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student : Auditable<int>
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
