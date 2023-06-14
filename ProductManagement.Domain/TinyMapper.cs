using ProductManagement.Core.Concerns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntities = ProductManagement.Data.Entities;

namespace ProductManagement.Domain
{
    /// <summary>
    /// Tyny Mapper instance
    /// </summary>
    public static class TinyMapper
    {
        /// <summary>
        /// Maps to.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public static Product MapTo(DataEntities.Product product)
        {
            return new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                PricePerItem = product.PricePerItem,
                AverageCustomerRating = product.AverageCustomerRating,
                ProductAttributes = product.ProductAttributes?.Select(_ => MapTo(_)).ToList()

            };
        }

        /// <summary>
        /// Maps to.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public static DataEntities.Product MapTo(Product product)
        {
            return new DataEntities.Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                PricePerItem = product.PricePerItem,
                AverageCustomerRating = product.AverageCustomerRating,
                ProductAttributes = product.ProductAttributes?.Select(_ => MapTo(_)).ToList()
            };
        }
        /// <summary>
        /// Maps to.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public static ProductAttribute MapTo(DataEntities.ProductAttribute product)
        {
            return new ProductAttribute()
            {
                ProductAttributeId = product.ProductAttributeId,
                Color = product.Color,
                Height = product.Height,
                Tag = product.Tag,
                Width = product.Width,
               // Product = MapTo(product.Product)
            };
        }
        /// <summary>
        /// Maps to.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <returns></returns>
        public static DataEntities.ProductAttribute MapTo(ProductAttribute product)
        {
            return new DataEntities.ProductAttribute()
            {
                ProductAttributeId = product.ProductAttributeId,
                Color = product.Color,
                Height = product.Height,
                Tag = product.Tag,
                Width = product.Width,
               // Product = MapTo(product.Product)
            };
        }
    }
}
