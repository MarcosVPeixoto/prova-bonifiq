using ProvaPub.Data;
using ProvaPub.IRepositories;
using ProvaPub.Models;

namespace ProvaPub.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TestDbContext _context; 
        public ProductRepository(TestDbContext context)
        {
            _context = context;
        }
        public ProductList ListProducts(int page)
        {
            var count = _context.Products.Count();
            var hasNext = count % (page * 10) > 0;
            var skip = (page - 1) * 10;
            var products = _context.Products
                                   .Skip(skip)
                                   .Take(10)
                                   .ToList();
            return new ProductList() { HasNext = hasNext, TotalCount = count, Products = products };
        }
    }
}
