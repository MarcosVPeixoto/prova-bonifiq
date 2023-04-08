using ProvaPub.IRepositories;

namespace ProvaPub.Repositories
{
    public static class RepositoriesExtesions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

        }
    }
}
