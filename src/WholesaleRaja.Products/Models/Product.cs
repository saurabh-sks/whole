using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WholesaleRaja.Products.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string SKU { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? SavingsAmount { get; set; }
        public int? SavingsPercentage { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoMetaKeywords { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DisabledDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DisabledBy { get; set; }

        public string BasePriceString { get; set; }

        public string SalePriceString { get; set; }

        public string SavingsAmountString { get; set; }
    }
}