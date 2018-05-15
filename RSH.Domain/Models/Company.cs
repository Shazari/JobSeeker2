using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company:Domain.Infrastracture.BaseEntity
    {
        public Company():base()
        {
        }

        public string CompanyName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        
        public string Other { get; set; }
    }
}
