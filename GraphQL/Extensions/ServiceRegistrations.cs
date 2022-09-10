using GraphQL.Data;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Extensions
{
    public static class ServiceRegistrations
    {
        public static void RunServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DiscountDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DiscountConnectionString")));


        }
    }
}
