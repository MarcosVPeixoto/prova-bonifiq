using ProvaPub.Models;
using ProvaPub.Data;
using ProvaPub.IServices;
using ProvaPub.IRepositories;

namespace ProvaPub.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;

		public ProductService(IProductRepository productRepository)
		{
			_productRepository = productRepository;

        }

		public ProductList ListProducts(int page)
		{
			if (page <= 0) page = 1;
			return _productRepository.ListProducts(page);
		}

	}
}
