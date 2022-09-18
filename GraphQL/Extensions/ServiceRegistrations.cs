using System.Data;
using GraphQL.Data;
using GraphQL.GraphQL;
using GraphQL.GraphQL.Categories;
using GraphQL.GraphQL.Coupons;
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
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddType<CategoryType>()
                .AddType<AddCategoryInputType>()
                .AddType<AddCategoryPayloadType>()
                .AddType<CouponType>()
                .AddType<AddCouponInputType>()
                .AddType<AddCategoryPayloadType>()
                .AddFiltering()
                .AddSorting();
        }
    }
}
