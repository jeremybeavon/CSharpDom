using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class FieldFactory : AbstractFactory<IField, Field>
    {
        public FieldFactory(IField field)
            : base(field)
        {
        }

        public override void VisitField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            Value = new Field()
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
