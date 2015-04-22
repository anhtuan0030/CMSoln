using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Core.Services
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }
        public string Subject { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
