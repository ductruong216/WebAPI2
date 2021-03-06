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
    
    public partial class Opportunity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Opportunity()
        {
            this.Activities = new HashSet<Activity>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ProjectCategoryId { get; set; }
        public string ClientContactId { get; set; }
        public Nullable<int> ProbabilityWinning { get; set; }
        public Nullable<System.DateTime> ForcastCloseDate { get; set; }
        public string ResponsibleStaffId { get; set; }
        public Nullable<decimal> Value { get; set; }
        public int StatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ProjectCategory ProjectCategory { get; set; }
        public virtual Status Status { get; set; }
    }
}
