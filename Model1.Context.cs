﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace school
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class schoolEntities : DbContext
    {
        public schoolEntities()
            : base("name=schoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClassRoom> ClassRoom { get; set; }
        public virtual DbSet<Flow> Flow { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubject { get; set; }
        public virtual DbSet<Ttimetable> Ttimetable { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
