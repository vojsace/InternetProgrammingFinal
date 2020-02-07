using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportApplication.Models
{
    public class Sport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SportID { get; set; }
        public string SportTitle { get; set; }
        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
