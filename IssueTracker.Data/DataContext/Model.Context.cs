﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueTracker.Data.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using IssueTracker.Domain;
    
    public partial class IssuesEntities : DbContext
    {
        public IssuesEntities()
            : base("name=IssuesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<MessageAttachment> MessageAttachment { get; set; }
        public DbSet<Thread> Thread { get; set; }
        public DbSet<ThreadAttachment> ThreadAttachment { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
