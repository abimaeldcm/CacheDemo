using CacheDemo.Models;

namespace CacheDemo.Data
{
    public static class AppData
    {
        public static List<Product> Estoque()
        {

            List<Product> Products = new List<Product>
            {
                new Product { Id = 1, Name = "Geladeira", Price = 1899.99m },
                new Product { Id = 2, Name = "Ventilador", Price = 399.99m },
                new Product { Id = 3, Name = "Cama", Price = 1299.99m },
                new Product { Id = 4, Name = "Micro-ondas", Price = 599.99m },
                new Product { Id = 5, Name = "Fogão", Price = 899.99m },
                new Product { Id = 6, Name = "Televisão LED 4K", Price = 2399.99m },
                new Product { Id = 7, Name = "Aspirador de Pó", Price = 249.99m },
                new Product { Id = 8, Name = "Máquina de Lavar", Price = 1499.99m }
            };

            return Products;
        }
    }
}
