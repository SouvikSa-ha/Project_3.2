//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Reminder
    {
        public int Id { get; set; }
        public string Reminder_Id { get; set; }
        public int Uid { get; set; }
        public string Reminder_Time { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public System.DateTime Deadline { get; set; }
    
        public virtual User User { get; set; }
    }
}