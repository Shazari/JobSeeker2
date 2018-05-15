using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Person: Domain.Infrastracture.BaseEntity
    {
        public Person():base()
        {
        }

        [Display(Name = "نام")]
        [StringLength(maximumLength: 20)]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید", AllowEmptyStrings = false)]
        [StringLength(maximumLength: 30)]
//        [System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = false)]
        public string LastName { get; set; }


        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید", AllowEmptyStrings = false)]
        [StringLength(maximumLength: 15)]
        
        public string Mobile { get; set; }

        [Display(Name = "تلفن ضروری")]
        [StringLength(maximumLength: 15)]
        public string EmergancyPhone { get; set; }

        [Display(Name = "رزومه")]
        public string ResumeUrl { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید", AllowEmptyStrings = false)]
        [StringLength(maximumLength: 50)]
        [System.ComponentModel.DataAnnotations.Schema.Index
(IsUnique = true)]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید", AllowEmptyStrings = false)]
        [StringLength(maximumLength: 30)]
        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<Apply> Apply { get; set; }
        public ICollection<CoverLetter> CoverLetter { get; set; }
        public ICollection<Resume> Resume { get; set; }
        public ICollection<Interview> Interview { get; set; }
    }
}
