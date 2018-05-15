using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tools.Abstracts
{
    public interface IUnitOfWork:IDisposable
    {
        IApplyRepository ApplyRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        ICoverLetterRepository CoverLetterRepository { get; }
        IInterviewRepository InterviewRepository { get; }
        IPersonRepository PersonRepository { get; }
        IResumeRepository ResumeRepository { get; }
        IStatusRepository StatusRepository { get; }
        ITemplateRepository TemplateRepository { get; }


        void Save();
    }
}
