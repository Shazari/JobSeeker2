using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Apply:Domain.Infrastracture.BaseEntity
    {
        public Apply():base()
        {
        }

        
        public DateTime ApplyDate { get; set; }
        public string ApplyMethod { get; set; }
        public string Description { get; set; }
        public int PersonID { get; set; }
        public int ResumeID { get; set; }
        public int CoverLetterID { get; set; }
        public int CompanyID { get; set; }
        public int StatusID { get; set; }


        [ForeignKey("PersonID")]
        public Person Person { get; set; }

        [ForeignKey("ResumeID")]
        public Resume Resume { get; set; }

        [ForeignKey("CoverLetterID")]
        public CoverLetter CoverLetter { get; set; }

        [ForeignKey("CompanyID")]
        public Company Company { get; set; }

        [ForeignKey("StatusID")]
        public Status Status { get; set; }

    }
}
