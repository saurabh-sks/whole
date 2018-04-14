using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WholesaleRaja.Products.Models;
using WholesaleRaja.Database;
using System.Globalization;

namespace WholesaleRaja.Products.Helpers
{
    public class ProductHelper
    {
        private static DateTime GetIndianTime()
        {
            TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime indianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
            return indianTime;
        }

        public static void AddProduct(Product prod)
        {
            CultureInfo hindi = new CultureInfo("hi-IN");
            //string currencySymbol = hindi.NumberFormat.CurrencySymbol;
            //string basePriceString = string.Format("{0} {1}", currencySymbol, string.Format(hindi, "{0:c}", prod.BasePrice));
            //string salePriceString = string.Format("{0} {1}", currencySymbol, string.Format(hindi, "{0:c}", prod.SalePrice));
            //string savingsAmountString = string.Format("{0} {1}", currencySymbol, string.Format(hindi, "{0:c}", prod.SavingsAmount));
            string basePriceString = string.Format(hindi, "{0:c}", prod.BasePrice);
            string salePriceString = string.Format(hindi, "{0:c}", prod.SalePrice);
            string savingsAmountString = string.Format(hindi, "{0:c}", prod.SavingsAmount);

            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                WSR_Product dbProduct = new WSR_Product
                {
                    Name = prod.Name,
                    Image = prod.Image,
                    SKU = prod.SKU,
                    IsActive = prod.IsActive,
                    Description = prod.Description,
                    BasePrice = prod.BasePrice,
                    SalePrice = prod.SalePrice,
                    SavingsAmount = prod.SavingsAmount,
                    SavingsPercentage = prod.SavingsPercentage,
                    SeoTitle = prod.SeoTitle,
                    SeoDescription = prod.SeoDescription,
                    SeoMetaKeywords = prod.SeoMetaKeywords,
                    CreatedDate = prod.CreatedDate,
                    CreatedBy = prod.CreatedBy,
                    BasePriceString = basePriceString,
                    SalePriceString = salePriceString,
                    SavingsAmountString = savingsAmountString
                };
                db.WSR_Product.Add(dbProduct);
                db.SaveChanges();
            }

        }

        public static Product GetProductDetails(string productId)
        {
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                WSR_Product prod = db.WSR_Product.Where(x => x.ProductId.ToString() == productId).FirstOrDefault();
                if (prod != null && !string.IsNullOrWhiteSpace(prod.Name))
                {
                    Product product = new Product
                    {
                        ProductId = prod.ProductId,
                        Name = prod.Name,
                        Image = prod.Image,
                        SKU = prod.SKU,
                        Description = prod.Description,
                        BasePrice = prod.BasePrice,
                        SalePrice = prod.SalePrice,
                        SavingsAmount = prod.SavingsAmount,
                        SavingsPercentage = prod.SavingsPercentage,
                        SeoTitle = prod.SeoTitle,
                        SeoDescription = prod.SeoDescription,
                        SeoMetaKeywords = prod.SeoMetaKeywords,
                        BasePriceString = prod.BasePriceString,
                        SalePriceString = prod.SalePriceString,
                        SavingsAmountString = prod.SavingsAmountString
                    };

                    return product;
                }
                else
                {
                    return null;
                }

            }
        }

        public static bool AddCategory(string categoryName, string userName, string seoTitle, string seoDescription, string seoMetaKeywords)
        {
            List<WSR_ProductCategory> categoryList = new List<WSR_ProductCategory>();
            WSR_ProductCategory newCategory = new WSR_ProductCategory
            {
                CategoryName = categoryName,
                CategoryUrl = null,
                CreatedBy = userName,
                CreatedDate = GetIndianTime(),
                EnabledDate = GetIndianTime(),
                EnabledBy = userName,
                IsActive = true,
                IsSubcategory = false,
                SeoTitle = seoTitle,
                SeoDescription = seoDescription,
                SeoMetaKeywords = seoMetaKeywords,
            };

            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                categoryList = db.WSR_ProductCategory.ToList();
                bool categoryExists = categoryList.Where(x => x.IsSubcategory == false).Any(x => x.CategoryName.ToLower() == categoryName.ToLower());
                if (categoryExists)
                {
                    return false;
                }
                else
                {
                    db.WSR_ProductCategory.Add(newCategory);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public static bool AddSubcategory(int parentCategoryId, string userName, string subcategoryName, string subcategorySeoTitle, string subCategorySeoDesc, string subCategoryMetaKeywords)
        {
            List<WSR_ProductCategory> subCategoryList = new List<WSR_ProductCategory>();
            WSR_ProductCategory newSubCategory = new WSR_ProductCategory
            {
                CategoryName = subcategoryName,
                CategoryUrl = null,
                ParentCategoryId = parentCategoryId,
                CreatedBy = userName,
                CreatedDate = GetIndianTime(),
                EnabledDate = GetIndianTime(),
                EnabledBy = userName,
                IsActive = true,
                IsSubcategory = true,
                SeoTitle = subcategorySeoTitle,
                SeoDescription = subCategorySeoDesc,
                SeoMetaKeywords = subCategoryMetaKeywords,
            };
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                subCategoryList = db.WSR_ProductCategory.Where(x=>x.ParentCategoryId== parentCategoryId && x.IsSubcategory == true).ToList();
                bool subCategoryExists = subCategoryList.Where(x => x.ParentCategoryId == parentCategoryId && x.IsSubcategory == true).Any(x => x.CategoryName.ToLower() == subcategoryName.ToLower());
                if (subCategoryExists)
                {
                    return false;
                }
                else
                {
                    db.WSR_ProductCategory.Add(newSubCategory);
                    db.SaveChanges();
                    return true;
                }
            }
        }

        public static List<WSR_ProductCategory> GetAllCategoryDetails()
        {
            List<WSR_ProductCategory> categoryList = new List<WSR_ProductCategory>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                categoryList = db.WSR_ProductCategory.Where(x => x.IsSubcategory == false).ToList();
            }
            return categoryList;
        }

        public static List<WSR_ProductCategory> GetSubCategory(int categoryId)
        {
            List<WSR_ProductCategory> subCategoryList = new List<WSR_ProductCategory>();
            using (WholesaleRajaEntities db = new WholesaleRajaEntities())
            {
                subCategoryList = db.WSR_ProductCategory.Where(x => x.ParentCategoryId == categoryId).ToList();
            }
            return subCategoryList;
        }
    }
}