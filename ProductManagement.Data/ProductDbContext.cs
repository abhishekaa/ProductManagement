using Microsoft.EntityFrameworkCore;
using ProductManagement.Data.Entities;

namespace ProductManagement.Data
{
    /// <summary>
    /// Product Db Context
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class ProductDbContext : DbContext
    {
        /// <summary>
        /// Override this method to configure the database (and other options) to be used for this context.
        /// This method is called for each instance of the context that is created.
        /// The base implementation does nothing.
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context. Databases (and other extensions)
        /// typically define extension methods on this object that allow you to configure the context.</param>
        /// <remarks>
        /// <para>
        /// In situations where an instance of <see cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may not have been passed
        /// to the constructor, you can use <see cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" /> to determine if
        /// the options have already been set, and skip some or all of the logic in
        /// <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" />.
        /// </para>
        /// <para>
        /// See <see href="https://aka.ms/efcore-docs-dbcontext">DbContext lifetime, configuration, and initialization</see>
        /// for more information and examples.
        /// </para>
        /// </remarks>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ProductDb");
        }
        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// <para>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run. However, it will still run when creating a compiled model.
        /// </para>
        /// <para>
        /// See <see href="https://aka.ms/efcore-docs-modeling">Modeling entity types and relationships</see> for more information and
        /// examples.
        /// </para>
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 1, ProductName = "Product 1", PricePerItem = 100, AverageCustomerRating = 4 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 2, ProductName = "Product 2", PricePerItem = 200, AverageCustomerRating = 5 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 3, ProductName = "Product 3", PricePerItem = 300, AverageCustomerRating = 4 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 4, ProductName = "Product 4", PricePerItem = 100, AverageCustomerRating = 5 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 5, ProductName = "Product 5", PricePerItem = 200, AverageCustomerRating = 4 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 6, ProductName = "Product 6", PricePerItem = 300, AverageCustomerRating = 3 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 7, ProductName = "Product 7", PricePerItem = 100, AverageCustomerRating = 4 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 8, ProductName = "Product 8", PricePerItem = 200, AverageCustomerRating = 1 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 9, ProductName = "Product 9", PricePerItem = 300, AverageCustomerRating = 3 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 10, ProductName = "Product 10", PricePerItem = 100, AverageCustomerRating = 5 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 11, ProductName = "Product 11", PricePerItem = 200, AverageCustomerRating = 2 });
            modelBuilder.Entity<Product>().HasData(new Product { ProductId = 12, ProductName = "Product 12", PricePerItem = 300, AverageCustomerRating = 1 });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute { ProductAttributeId = 1, Color = "RED", Height = 1, Width = 2, ProductId = 1, Tag = "" });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute { ProductAttributeId = 2, Color = "GREEN", Height = 1, Width = 2, ProductId = 1, Tag = "" });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute { ProductAttributeId = 3, Color = "BLUE", Height = 1, Width = 2, ProductId = 1, Tag = "" });

            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute { ProductAttributeId = 4, Color = "RED", Height = 1, Width = 2, ProductId = 2, Tag = "" });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute { ProductAttributeId = 5, Color = "GREEN", Height = 1, Width = 2, ProductId = 2, Tag = "" });
            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute { ProductAttributeId = 6, Color = "BLUE", Height = 1, Width = 2, ProductId = 2, Tag = "" });
        }
        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        /// <value>
        /// The products.
        /// </value>
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// Gets or sets the product attributes.
        /// </summary>
        /// <value>
        /// The product attributes.
        /// </value>
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
    }
}