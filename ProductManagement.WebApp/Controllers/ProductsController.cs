using Microsoft.AspNetCore.Mvc;
using ProductManagement.Core.Concerns;
using ProductManagement.Core.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagement.WebApp.Controllers
{
    /// <summary>
    /// Product Controler
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Gets or sets the product service.
        /// </summary>
        /// <value>
        /// The product service.
        /// </value>
        IProductService ProductService { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// </summary>
        /// <param name="productService">The product service.</param>
        public ProductsController(IProductService productService)
        {
            ProductService=productService;
        }
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await this.ProductService.GetProducts();
        }

        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await this.ProductService.GetProductById(id);
        }

        /// <summary>
        /// Gets the attributes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpGet("{id}/Attributes")]
        public async Task<IEnumerable<ProductAttribute>> GetAttributes(int id)
        {
            return await this.ProductService.GetAttributesByProductId(id);
        }
  
    }
}
