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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Work_team_employee = new HashSet<Work_team_employee>();
        }
    
        public int Employee_code { get; set; }
        public Nullable<int> Employee_type_code { get; set; }
        public Nullable<int> Employee_registration_code { get; set; }
        public string First_name { get; set; }
        public string Second_name { get; set; }
        public string Patronymic { get; set; }
        public Nullable<decimal> Mobile_number { get; set; }
    
        public virtual Employee_registration Employee_registration { get; set; }
        public virtual Employee_type Employee_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Work_team_employee> Work_team_employee { get; set; }
    }
}
