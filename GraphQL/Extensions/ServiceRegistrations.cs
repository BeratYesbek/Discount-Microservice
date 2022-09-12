using System.Data;
using GraphQL.Data;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Extensions
{
    public static class ServiceRegistrations
    {
        public static void RunServices(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddPooledDbContextFactory<DiscountDbContext>(opt => opt.UseSqlServer
                (configuration.GetConnectionString("DiscountConnectionString")));

            service
                .AddGraphQLServer()
                .AddQueryType<DbLoggerCategory.Query>()
                .AddType<CommandType>()
                .AddFiltering()
                .AddSorting()
                .AddInMemorySubscriptions();
        }
    }
}
