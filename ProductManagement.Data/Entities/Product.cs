using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Data.Entities
{
    /// <summary>
    /// Product Class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        [Key]
        public int ProductId { get; set; }
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        public string ProductName { get; set; }=string.Empty;
        /// <summary>
        /// Gets or sets the price per item.
        /// </summary>
        /// <value>
        /// The price per item.
        /// </value>
        public decimal PricePerItem { get; set; }
        /// <summary>
        /// Gets or sets the average customer rating.
        /// </summary>
        /// <value>
        /// The average customer rating.
        /// </value>
        public int AverageCustomerRating { get; set; }

        /// <summary>
        /// Gets or sets the product attributes.
        /// </summary>
        /// <value>
        /// The product attributes.
        /// </value>
        public ICollection<ProductAttribute> ProductAttributes { get; set;}
    }
}
