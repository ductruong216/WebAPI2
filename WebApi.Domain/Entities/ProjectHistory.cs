//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectHistory
    {
        public int Id { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ActivityTypeId { get; set; }
        public string CreatedById { get; set; }
        public Nullable<System.DateTime> CreatedByDateTime { get; set; }
        public string Description { get; set; }
    
        public virtual ActivityType ActivityType { get; set; }
        public virtual ProjectHistory ProjectHistory1 { get; set; }
        public virtual ProjectHistory ProjectHistory2 { get; set; }
    }
}
