using GraphQL.Data;
using GraphQL.Models;

namespace GraphQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(DiscountDbContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable coupons")]
        public IQueryable<Coupon>? GetCoupons([ScopedService] DiscountDbContext dbContext)
        {
            return dbContext.Coupons;
        }

        [UseDbContext(typeof(DiscountDbContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable categories")]
        public IQueryable<Category>? GetCategories([ScopedService] DiscountDbContext dbContext)
        {
            return dbContext.Categories;
        }
    }
}
