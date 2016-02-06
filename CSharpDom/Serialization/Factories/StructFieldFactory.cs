using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructFieldFactory : AbstractFactory<IStructField, StructField>
    {
        public StructFieldFactory(IStructField field)
            : base(field)
        {
        }

        public override void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            Value = new StructField()
            {
                Attributes = field.Attributes.ToAttributeListUsingFactory(),
                FieldType = new TypeReferenceFactory(field.FieldType).Value,
                Modifier = field.Modifier,
                Name = field.Name,
                Visibility = field.Visibility
            };
        }
    }
}
