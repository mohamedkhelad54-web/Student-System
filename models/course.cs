using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.models
{
    public class course
    {
        public int courseid { get; set; }

        [Column(TypeName ="nvarchar(80)")]            
        public string name { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string? discription { get; set; }
        public decimal price { get; set; }
        
    }
}
