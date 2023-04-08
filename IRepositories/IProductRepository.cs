using ProvaPub.Models;

namespace ProvaPub.IRepositories
{
    public interface IProductRepository
    {
        ProductList ListProducts(int page);
    }
}
