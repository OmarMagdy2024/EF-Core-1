using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.Classes
{
    internal class Course
    {
        public int Id { get; set; }
        public TimeOnly Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Topic_ID { get; set; }
    }
}
