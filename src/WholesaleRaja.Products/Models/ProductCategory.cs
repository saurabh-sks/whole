using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WholesaleRaja.Products.Models
{
    public class ProductCategory
    {
        public static int CategoryId { get; set; }
        public static string CategoryName { get; set; }
        public static bool IsSubcategory { get; set; }
        public static int? ParentCategoryId { get; set; }
        public static string ParentCategoryName { get; set; }
        public static bool IsActive { get; set; }
        public static string SeoTitle { get; set; }
        public static string SeoDescription { get; set; }
        public static string SeoMetaKeywords { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static DateTime EnabledDate { get; set; }
        public static DateTime UpdatedDate { get; set; }
        public static DateTime DisabledDate { get; set; }
        public static string CreatedBy { get; set; }
        public static string EnabledBy { get; set; }
        public static string UpdatedBy { get; set; }
        public static string DisabledBy { get; set; }
    }
}