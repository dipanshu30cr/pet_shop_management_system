//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pet_shop_management_system.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string age { get; set; }
        public Nullable<int> breed_id { get; set; }
        public Nullable<int> type_id { get; set; }
    
        public virtual breed breed { get; set; }
        public virtual type type { get; set; }
    }
}
