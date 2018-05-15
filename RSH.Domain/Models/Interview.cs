using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Interview:Domain.Infrastracture.BaseEntity
    {
        public Interview():base()
        {
        }

        

        public DateTime InterviewDate { get; set; }

        public string InterviewBy { get; set; }

        public bool IsDone { get; set; }
        public int ApplyID { get; set; }

        [ForeignKey("ApplyID")]
        public Apply Apply { get; set; }

    }
}
