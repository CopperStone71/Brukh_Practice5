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
    
    public partial class Work_plan_task
    {
        public int Work_plan_task_code { get; set; }
        public Nullable<int> Work_plan_code { get; set; }
        public Nullable<int> Execution_status_code { get; set; }
        public Nullable<int> Work_plan_task_number { get; set; }
        public string Goal_of_task { get; set; }
    
        public virtual Execution_status Execution_status { get; set; }
        public virtual Work_plan Work_plan { get; set; }
    }
}
