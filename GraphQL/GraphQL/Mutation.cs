using AutoMapper;
using GraphQL.Data;
using GraphQL.GraphQL.Categories;
using GraphQL.GraphQL.Coupons;
using GraphQL.Models;
using System;

namespace GraphQL.GraphQL
{
    public class Mutation
    {
        private readonly IMapper _mapper;
        public Mutation(IMapper mapper)
        {
            _mapper = mapper;
        }

        [UseDbContext(typeof(DiscountDbContext))]
        public async Task<AddCouponPayload> AddCouponAsync(AddCouponInput addCouponInput, [ScopedService] DiscountDbContext dbContext)
        {
            var coupon = _mapper.Map<Coupon>(addCouponInput);
            dbContext.Add(coupon);
            await dbContext.SaveChangesAsync();
            return new AddCouponPayload(coupon);
        }

        [UseDbContext(typeof(DiscountDbContext))]
        public async Task<AddCategoryPayload> AddCategoryAsync(AddCategoryInput categoryInput,
            [ScopedService] DiscountDbContext dbContext)
        {
            var category = _mapper.Map<Category>(categoryInput);
            dbContext.Add(category);
            await dbContext.SaveChangesAsync();
            return new AddCategoryPayload(category);
        }
    }
}
