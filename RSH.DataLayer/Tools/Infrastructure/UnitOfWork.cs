using DataLayer.Tools.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Domain;
namespace DataLayer.Tools.Infrastructure
{
    public class UnitOfWork : object, IUnitOfWork
    {

        public UnitOfWork()
        {
            IsDisposed = false;
        }

        protected bool IsDisposed { get; set; }

        private ContextDB contextDB;
        protected ContextDB ContextDB
        {
            get
            {
                if(contextDB==null)
                {
                    contextDB = new ContextDB();
                }
                return contextDB;
            }
        }

        private IApplyRepository applyRepository;

        public IApplyRepository ApplyRepository
        {
            get
            {
                if(applyRepository==null)
                {
                    applyRepository = new ApplyRepository(ContextDB);
                }
                return applyRepository;

            }
        }

        private ICompanyRepository companyRepository;

        public ICompanyRepository CompanyRepository
        {
            get
            {
                if (companyRepository == null)
                {
                    companyRepository = new CompanyRepository(ContextDB);
                }
                return companyRepository;

            }
        }
        private ICoverLetterRepository coverLetterRepository;

        public ICoverLetterRepository CoverLetterRepository
        {
            get
            {
                if (coverLetterRepository == null)
                {
                    coverLetterRepository = new CoverLetterRepository(ContextDB);
                }
                return coverLetterRepository;

            }
        }
        private IInterviewRepository interviewRepository;

        public IInterviewRepository InterviewRepository
        {
            get
            {
                if (interviewRepository == null)
                {
                    interviewRepository = new InterviewRepository(ContextDB);
                }
                return interviewRepository;

            }
        }
        private IPersonRepository personRepository;

        public IPersonRepository PersonRepository
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository = new PersonRepository(ContextDB);
                }
                return personRepository;

            }
        }
        private IResumeRepository resumeRepository;

        public IResumeRepository ResumeRepository
        {
            get
            {
                if (resumeRepository == null)
                {
                    resumeRepository = new ResumeRepository(ContextDB);
                }
                return resumeRepository;

            }
        }
        private IStatusRepository statusRepository;

        public IStatusRepository StatusRepository
        {
            get
            {
                if (statusRepository == null)
                {
                    statusRepository = new StatusRepository(ContextDB);
                }
                return statusRepository;

            }
        }
        private ITemplateRepository templateRepository;

        public ITemplateRepository TemplateRepository
        {
            get
            {
                if (templateRepository == null)
                {
                    templateRepository = new TemplateRepository(ContextDB);
                }
                return templateRepository;

            }
        }

        public void Save()
        {
            try
            {
                ContextDB.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (IsDisposed == false)
            {
                if (disposing)
                {
                    contextDB.Dispose();
                }
            }
            IsDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
