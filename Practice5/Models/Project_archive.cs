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
    
    public partial class Project_archive
    {
        public int Project_archive_code { get; set; }
        public Nullable<int> Contract_code { get; set; }
        public Nullable<int> Tech_spec_code { get; set; }
        public Nullable<int> Estimates_code { get; set; }
        public Nullable<int> Tax_report_code { get; set; }
    
        public virtual Contract Contract { get; set; }
        public virtual Estimates Estimates { get; set; }
        public virtual Tax_report Tax_report { get; set; }
        public virtual Tech_spec Tech_spec { get; set; }
    }
}
