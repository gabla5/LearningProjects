//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Msts.Mvc.DataAccess.EFData
{
    using System;
    using System.Collections.Generic;
    
    public partial class job
    {
        public job()
        {
            this.employees = new HashSet<employee>();
        }
    
        public short job_id { get; set; }
        public string job_desc { get; set; }
        public byte min_lvl { get; set; }
        public byte max_lvl { get; set; }
    
        public virtual ICollection<employee> employees { get; set; }
    }
}
