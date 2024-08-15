using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.Classes
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ins_ID { get; set; }
        public DateOnly HitingDate { get; set; }
    }
}
