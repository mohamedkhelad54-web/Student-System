using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.models
{
   public class resourse
    {
        public enum ResourceType
        {
            Video,
            Presentation,
            Document,
            Other
        }
        public int resourseid { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string name { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string ulr { get; set; }
        public ResourceType resourceType { get; set; }
        public int studentid { get; set; }      
        [ForeignKey("studentid")]
        public student student { get; set; }
    }
}
