using ProvaPub.Models;

namespace ProvaPub.IServices
{
    public interface IProductService
    {
        ProductList ListProducts(int page);
    }
}
