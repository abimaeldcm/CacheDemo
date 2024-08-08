using CacheDemo.Data;
using CacheDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMemoryCache _memoryCache;

    public ProductsController(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    [HttpGet]
    public IActionResult Get()
    {
        const string cacheKey = "products";

        if (!_memoryCache.TryGetValue(cacheKey, out List<Product> products))
        {
            products = AppData.Estoque();

            var cacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            };
            _memoryCache.Set(cacheKey, products, cacheEntryOptions);
        }

        return Ok(products);
    }
}