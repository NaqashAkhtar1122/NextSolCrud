//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleTest.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubCategory
    {
        public int ID { get; set; }
        public int CatID { get; set; }
        public string Title { get; set; }
    
        public virtual Category Category { get; set; }
    }
}
