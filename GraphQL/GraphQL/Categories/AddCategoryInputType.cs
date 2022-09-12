namespace GraphQL.GraphQL.Categories
{
    public class AddCategoryInputType : InputObjectType<AddCategoryInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<AddCategoryInput> descriptor)
        {
            descriptor.Description("Represents the input to add for a category.");

            descriptor.Field(c => c.CategoryName)
                .Description("Represents the category-name for the category.");

            descriptor.Field(c => c.ExternalId)
                .Description("Represents the external-category-id for the category.");
            base.Configure(descriptor);
        }
    }
}
