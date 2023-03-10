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
    
    public partial class Visual_Boards
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visual_Boards()
        {
            this.BoardComponents = new HashSet<BoardComponent>();
            this.Collaborations = new HashSet<Collaboration>();
        }
    
        public int Id { get; set; }
        public string Board_Id { get; set; }
        public int Uid { get; set; }
        public Nullable<int> Tag_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoardComponent> BoardComponents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collaboration> Collaborations { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual User User { get; set; }
    }
}
