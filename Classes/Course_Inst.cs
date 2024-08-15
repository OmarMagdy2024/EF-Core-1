using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.Classes
{
    internal class Course_Inst
    {
        public int InstId { get; set; } 
        public int CourseId { get; set; }
        public string Evaluate { get; set; }

    }
}
