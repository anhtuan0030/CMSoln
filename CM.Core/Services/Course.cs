using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class Course
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Schedule { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
    }
}
