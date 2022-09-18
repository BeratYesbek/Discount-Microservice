using GraphQL.Models;

namespace GraphQL.GraphQL.Coupons
{
    public class AddCouponPayloadType : ObjectType<AddCouponPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddCouponPayload> descriptor)
        {
            descriptor.Description("Represents the payload to return for an added category.");

            descriptor.Field(c => c.Coupon).Description("Represents the added category.");

            base.Configure(descriptor);
        }
    }
}
