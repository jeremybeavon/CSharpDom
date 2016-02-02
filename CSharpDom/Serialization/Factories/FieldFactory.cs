using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class FieldFactory : AbstractFactory<IClassField, ClassField>
    {
        public FieldFactory(IClassField field)
            : base(field)
        {
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            Value = new ClassField()
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
