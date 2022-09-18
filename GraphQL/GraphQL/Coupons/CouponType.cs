using GraphQL.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System;
using GraphQL.Data;

namespace GraphQL.GraphQL.Coupons
{
    public class CouponType : ObjectType<Coupon>
    {
        protected override void Configure(IObjectTypeDescriptor<Coupon> descriptor)
        {

            descriptor.Description("Represents any executable coupon.");

            descriptor.Field(c => c.CategoryName)
                .Description("Represents the category-name for the coupon.");

            descriptor.Field(c => c.Code)
                .Description("Represents the code for the coupon.");

            descriptor.Field(c => c.Description)
                .Description("Represents the description for the coupon.");

            descriptor.Field(c => c.ExternalCategoryId)
                .Description("Represents the external-category-id for the coupon.");

            descriptor.Field(c => c.CategoryId)
                .Description("Represents the category-id for the coupon.");

            descriptor.Field(c => c.Amount)
                .Description("Represents the amount for the coupon.");

            descriptor.Field(c => c.CreatedAt)
                .Description("Represents the created-at for the coupon.");

            descriptor.Field(c => c.Expiry)
                .Description("Represents the expiry for the coupon.");

                descriptor.Field(c => c.Category)
                    .ResolveWith<Resolvers>(c => c.GetCoupons(default!, default!))
                    .UseDbContext<DiscountDbContext>()
                    .Description("This is the category to which the coupon belongs.");


            base.Configure(descriptor);
        }
        protected class Resolvers
        {
            public Category GetCoupons(Coupon coupon, [ScopedService] DiscountDbContext context)
            {
                return context.Categories!.FirstOrDefault(p => p.Id == coupon.CategoryId)!;
            }
        }
    }
}
