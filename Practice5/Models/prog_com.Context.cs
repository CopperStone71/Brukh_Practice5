﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class prog_comEntities : DbContext
    {
        public prog_comEntities()
            : base("name=prog_comEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Client_type> Client_type { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Employee_registration> Employee_registration { get; set; }
        public virtual DbSet<Employee_type> Employee_type { get; set; }
        public virtual DbSet<Estimates> Estimates { get; set; }
        public virtual DbSet<Execution_status> Execution_status { get; set; }
        public virtual DbSet<Project_archive> Project_archive { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tax_report> Tax_report { get; set; }
        public virtual DbSet<Tech_spec> Tech_spec { get; set; }
        public virtual DbSet<Work_plan> Work_plan { get; set; }
        public virtual DbSet<Work_plan_task> Work_plan_task { get; set; }
        public virtual DbSet<Work_team> Work_team { get; set; }
        public virtual DbSet<Work_team_employee> Work_team_employee { get; set; }
    }
}
