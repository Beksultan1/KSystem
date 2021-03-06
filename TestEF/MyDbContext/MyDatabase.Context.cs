﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEF.MyDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KSysContext : DbContext
    {
        public KSysContext()
            : base("name=KSysContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Knowledge> Knowledge { get; set; }
        public virtual DbSet<Nomination> Nomination { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<CertificationTest> CertificationTest { get; set; }
        public virtual DbSet<SportProgramming> SportProgramming { get; set; }
        public virtual DbSet<Selection> Selection { get; set; }
        public virtual DbSet<SelectionUser> SelectionUser { get; set; }
    
        public virtual ObjectResult<SelectionSearch_Result> SelectionSearch(Nullable<int> educationId, Nullable<int> experienceId, Nullable<int> trainingId, Nullable<int> certificationId, Nullable<int> sportProgrammingId)
        {
            var educationIdParameter = educationId.HasValue ?
                new ObjectParameter("educationId", educationId) :
                new ObjectParameter("educationId", typeof(int));
    
            var experienceIdParameter = experienceId.HasValue ?
                new ObjectParameter("experienceId", experienceId) :
                new ObjectParameter("experienceId", typeof(int));
    
            var trainingIdParameter = trainingId.HasValue ?
                new ObjectParameter("trainingId", trainingId) :
                new ObjectParameter("trainingId", typeof(int));
    
            var certificationIdParameter = certificationId.HasValue ?
                new ObjectParameter("certificationId", certificationId) :
                new ObjectParameter("certificationId", typeof(int));
    
            var sportProgrammingIdParameter = sportProgrammingId.HasValue ?
                new ObjectParameter("sportProgrammingId", sportProgrammingId) :
                new ObjectParameter("sportProgrammingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectionSearch_Result>("SelectionSearch", educationIdParameter, experienceIdParameter, trainingIdParameter, certificationIdParameter, sportProgrammingIdParameter);
        }
    }
}
