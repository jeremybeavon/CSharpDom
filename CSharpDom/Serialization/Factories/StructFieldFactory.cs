using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructFieldFactory : AbstractFactory<IStructField, StructField>
    {
        public StructFieldFactory(IStructField field)
            : base(field)
        {
        }

        public override void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Value = new StructField()
            {
                Attributes = field.Attributes.ToAttributeListUsingFactory(),
                Fields = field.Fields.ToList(child => new FieldFactory(child).Value),
                FieldType = new TypeReferenceFactory(field.FieldType).Value,
                Modifier = field.Modifier,
                Visibility = field.Visibility
            };
        }
    }
}
