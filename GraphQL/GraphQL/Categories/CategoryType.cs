using GraphQL.Data;
using GraphQL.Models;
using HotChocolate;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.GraphQL.Categories
{
    public class CategoryType : ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            descriptor.Description("Represents any executable category.");

            descriptor.Field(c => c.Id)
                .Description("Represents the unique ID for the category.");

            descriptor.Field(c => c.ExternalId)
                .Description("Represents the external-category-id for the category.");

            descriptor.Field(p => p.Coupons)
                .ResolveWith<Resolvers>(p => p.GetCategories(default!,default!))
                .UseDbContext<DiscountDbContext>()
                .Description("This is the list of coupons for this category");

            base.Configure(descriptor);
        }

        public class Resolvers
        {
            public IQueryable<Coupon> GetCategories(Category category, [ScopedService] DiscountDbContext context)
            {
                return context.Coupons!.Where(t => t.CategoryId == category.Id);
            }
        }
    }
}
