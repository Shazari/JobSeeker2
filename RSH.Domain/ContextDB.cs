using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain
{
    public class ContextDB: DbContext
    {

        public ContextDB()
          : base("JobSeekerConnection")
        {
        }


        #region Map To Database

        public virtual DbSet<Apply> Apply { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CoverLetter> CoverLetter { get; set; }
        public virtual DbSet<Interview> Interview { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Resume> Resume { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public virtual DbSet<Template> Template { get; set; }


        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<UserCMS>().ToTable("UserCMS");
            //modelBuilder.Entity<Category>().Property(x => x.Title).IsRequired();

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Person>().HasMany(i => i.CoverLetter).WithRequired().WillCascadeOnDelete(false);
            modelBuilder.Entity<CoverLetter>().HasRequired(i => i.Person).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Person>().HasMany(i => i.Apply).WithRequired().WillCascadeOnDelete(false);
            modelBuilder.Entity<Person>().HasMany(i => i.Interview).WithRequired().WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Person>().HasMany(i => i.Resume).WithRequired().WillCascadeOnDelete(false);
            modelBuilder.Entity<Resume>().HasRequired(i => i.Person).WithMany().WillCascadeOnDelete(false);


            //modelBuilder.Entity<CoverLetter>()
            //    .HasRequired(t => t.Person)
            //    .WithMany()
            //    .HasForeignKey(d => d.PersonID)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Resume>()
            //    .HasRequired(t => t.Person)
            //    .WithMany()
            //    .HasForeignKey(d => d.PersonID)
            //    .WillCascadeOnDelete(false);



            //modelBuilder.Entity<Person>()
            //.HasRequired(c => c.CoverLetter)
            //.WithMany()
            //.WillCascadeOnDelete(false);
            //modelBuilder.Entity<Person>()
            //.HasKey(c => c.Id)
            //.HasRequired(c => c.Apply)
            //.WithMany()
            //.WillCascadeOnDelete(false);
            //modelBuilder.Entity<Person>()
            //.HasKey(c => c.Id)
            //.HasRequired(c => c.Interview)
            //.WithMany()
            //.WillCascadeOnDelete(false);
            //modelBuilder.Entity<Person>()
            //.HasKey(c => c.Id)
            //.HasRequired(c => c.Resume)
            //.WithMany()
            //.WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);

        }

        #region Add Constructor Identity Classes

        static ContextDB()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            // Database.SetInitializer<ContextDB>(new ApplicationDbInitializer());
        }

        

        #endregion


    }
}