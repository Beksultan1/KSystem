//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SelectionUser
    {
        public int Id { get; set; }
        public Nullable<int> SelectionId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<bool> IsSelected { get; set; }
    
        public virtual Selection Selection { get; set; }
        public virtual User User { get; set; }
    }
}
