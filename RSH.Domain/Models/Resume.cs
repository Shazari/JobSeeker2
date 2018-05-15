using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Resume:Domain.Infrastracture.BaseEntity
    {
        public Resume():base()
        {
        }

        public string Title { get; set; }

        public string Resume_Url { get; set; }

        public DateTime UploadDate { get; set; }
        public int PersonID { get; set; }

        [ForeignKey("PersonID")]
        public Person Person { get; set; }
    }
}
