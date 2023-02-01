﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevCom.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DevComDBEntities : DbContext
    {
        public DevComDBEntities()
            : base("name=DevComDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<BoardComponent> BoardComponents { get; set; }
        public virtual DbSet<Canvas> Canvases { get; set; }
        public virtual DbSet<Collaboration> Collaborations { get; set; }
        public virtual DbSet<Color_Palletes> Color_Palletes { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<NoteContent> NoteContents { get; set; }
        public virtual DbSet<Notepad> Notepads { get; set; }
        public virtual DbSet<PersonalVault> PersonalVaults { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Text> Texts { get; set; }
        public virtual DbSet<UI_Designs> UI_Designs { get; set; }
        public virtual DbSet<Update_Histories> Update_Histories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Visual_Boards> Visual_Boards { get; set; }
        public virtual DbSet<Workflow_Designs> Workflow_Designs { get; set; }
    }
}