using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTestovoe.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if(product.ProductId == 0)
            {
                product = context.Products.Add(product);
            }
            else
            {
                Product dbProduct = context.Products.Find(product.ProductId);
                if(dbProduct != null)
                {
                    dbProduct.Name = product.Name;
                    dbProduct.Description = product.Description;
                    dbProduct.Price = product.Price;
                    dbProduct.Category = product.Category;
                    dbProduct.Image = product.Image;
                }
            }
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}