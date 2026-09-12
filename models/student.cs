using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.models
{
    public class student
    {
       
        public int id { get; set; }

        [Column(TypeName="nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? phone_number { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string? birthday { get; set; }
        public int courseid { get; set; }
        [ForeignKey("courseid")]
       public course course { get; set; }

    }
}
