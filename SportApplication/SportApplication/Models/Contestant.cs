using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Models
{
    public class Contestant
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ICollection<Sport> Sports { get; set; }
    }
}
