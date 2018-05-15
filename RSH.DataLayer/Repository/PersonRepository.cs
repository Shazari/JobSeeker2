using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Tools.Abstracts;
using Models;
using Domain;

namespace DataLayer
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {

        public PersonRepository(ContextDB contextDB) : base(contextDB)
        {
        }
        
    }
}
