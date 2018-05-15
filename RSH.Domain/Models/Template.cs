using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Template:Domain.Infrastracture.BaseEntity
    {
        public Template():base()
        {
        }

        public string Title { get; set; }
        public string TemplateBody { get; set; }
    }
}
