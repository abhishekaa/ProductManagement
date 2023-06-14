using Microsoft.EntityFrameworkCore;
using ProductManagement.Core.Concerns;
using ProductManagement.Core.Contracts;
using ProductManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Domain
{
    /// <summary>
    /// Product Service 
    /// </summary>
    /// <seealso cref="ProductManagement.Core.Contracts.IProductService" />
    public class ProductService : IProductService
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductService"/> class.
        /// </summary>
        public ProductService()
        {
                
        }
        /// <summary>
        /// Gets the attributes by product identifier.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        public async Task<List<ProductAttribute>> GetAttributesByProductId(int productId)
        {
            using (var context = new ProductDbContext())
            {
                var dbProductAttributes = await context.ProductAttributes.Where(p => p.ProductId == productId).ToListAsync();
                return dbProductAttributes.Select(_ => TinyMapper.MapTo(_)).ToList();
            }
        }

        /// <summary>
        /// Gets the product by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int id)
        {
            using (var context = new ProductDbContext())
            {
                var dbProduct = await context.Products.Where(p => p.ProductId == id).FirstOrDefaultAsync();
                return TinyMapper.MapTo(dbProduct);
            }
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetProducts()
        {
           
                using (var context = new ProductDbContext())
                {
                    context.Database.EnsureCreated();
                    var dbProducts = await context.Products.ToListAsync();
                    return dbProducts.Select(_ => TinyMapper.MapTo(_)).ToList();
                }
        }
    }
}
