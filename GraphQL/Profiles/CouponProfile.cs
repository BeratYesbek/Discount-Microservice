using AutoMapper;
using GraphQL.GraphQL.Coupons;
using GraphQL.Models;

namespace GraphQL.Profiles
{
    public class CouponProfile : Profile    
    {
        public CouponProfile()
        {
            CreateMap<Coupon, AddCouponInput>().ReverseMap();
        }
    }
}
