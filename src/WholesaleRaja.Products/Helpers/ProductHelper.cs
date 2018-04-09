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
                if (prod !=null && !string.IsNullOrWhiteSpace(prod.Name))
                {
                    Product product = new Product
                    {
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
    }
}