namespace GraphQL.GraphQL.Coupons
{
    public record AddCouponInput(string Description, string Code, string CategoryName, int ExternalCategoryId, int CategoryId, float Amount, DateTime CreatedAt, DateTime Expiry);

}
