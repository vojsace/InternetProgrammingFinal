using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int SportID { get; set; }
        public int ContestantID { get; set; }

        public Sport Sport { get; set; }
        public Contestant Contestant { get; set; }
    }
}

