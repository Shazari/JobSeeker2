using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Status:Domain.Infrastracture.BaseEntity
    {
        public Status():base()
        {
        }

        public string StatusType { get; set; }
    }
}
