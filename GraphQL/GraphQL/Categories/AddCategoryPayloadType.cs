namespace GraphQL.GraphQL.Categories
{
    public class AddCategoryPayloadType : ObjectType<AddCategoryPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddCategoryPayload> descriptor)
        {
            descriptor.Description("Represents the payload to return for an added category.");

            descriptor.Field(c => c.Category).Description("Represents the added category.");

            base.Configure(descriptor);
        }
    }
}
