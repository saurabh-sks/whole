//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WholesaleRaja.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class WSR_ProductCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Nullable<bool> IsSubcategory { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoMetaKeywords { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> EnabledDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DisabledDate { get; set; }
        public string CreatedBy { get; set; }
        public string EnabledBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DisabledBy { get; set; }
        public Nullable<int> ParentCategoryId { get; set; }
        public string CategoryUrl { get; set; }
    }
}
