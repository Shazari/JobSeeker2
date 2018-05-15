using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DataLayer.Tools.Abstracts;
using Models;

namespace DataLayer
{
    public class InterviewRepository : Repository<Interview>, IInterviewRepository
    {

        public InterviewRepository(ContextDB contextDB) : base(contextDB)
        {
        }
        
    }
}
