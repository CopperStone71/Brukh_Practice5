//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Work_plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Work_plan()
        {
            this.Work_plan_task = new HashSet<Work_plan_task>();
            this.Work_team = new HashSet<Work_team>();
        }
    
        public int Work_plan_code { get; set; }
        public Nullable<int> Tech_spec_code { get; set; }
    
        public virtual Tech_spec Tech_spec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work_plan_task> Work_plan_task { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work_team> Work_team { get; set; }
    }
}
