using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastracture
{
    public class BaseEntity
    {
        public BaseEntity():base()
        {
        }

        public int Id { get; set; }
    }
}
