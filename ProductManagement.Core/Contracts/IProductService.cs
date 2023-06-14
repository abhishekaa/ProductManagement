using ProductManagement.Core.Concerns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductManagement.Core.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetProducts();
        /// <summary>
        /// Gets the product by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<Product> GetProductById(int id);

        /// <summary>
        /// Gets the attributes by product identifier.
        /// </summary>
        /// <param name="productId">The product identifier.</param>
        /// <returns></returns>
        Task<List<ProductAttribute>> GetAttributesByProductId(int productId);
    }
}
