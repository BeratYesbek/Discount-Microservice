namespace GraphQL.GraphQL.Coupons
{
    public class AddCouponInputType : InputObjectType<AddCouponInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddCouponInput> descriptor)
        {
            descriptor.Description("Represents the input to add for a coupon.");

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

            base.Configure(descriptor);
        }
    }
}
