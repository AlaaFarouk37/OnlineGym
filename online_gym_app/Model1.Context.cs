﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace online_gym_app
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gymEntities : DbContext
    {
        public gymEntities()
            : base("name=gymEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<administrator> administrators { get; set; }
        public DbSet<branch> branches { get; set; }
        public DbSet<@class> classes { get; set; }
        public DbSet<class_review> class_review { get; set; }
        public DbSet<class_type> class_type { get; set; }
        public DbSet<coach> coaches { get; set; }
        public DbSet<coach_speciality> coach_speciality { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<customer_pay_class> customer_pay_class { get; set; }
        public DbSet<fitness_information> fitness_information { get; set; }
        public DbSet<floor_coach> floor_coach { get; set; }
        public DbSet<guest> guests { get; set; }
        public DbSet<member> members { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<person> people { get; set; }
        public DbSet<person_phonenumber> person_phonenumber { get; set; }
        public DbSet<private_coach> private_coach { get; set; }
        public DbSet<receptionist> receptionists { get; set; }
        public DbSet<review> reviews { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<timetable> timetables { get; set; }
    }
}
