using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.models
{
   public class homework
    {
        public enum contentype
        {
            Application,
            Pdf ,
            Zip
        }
        public int homeworkid { get; set; }
        public contentype contentypes { get; set; }
       
        public int studentid { get; set; }
        [ForeignKey("studentid")]
        public student student { get; set; }
        public int? courseid { get; set; }
        [ForeignKey("courseid")]
        public course course{ get; set; }
    }
}
