using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassFieldFactory : AbstractFactory<IStaticClassField, StaticClassField>
    {
        public StaticClassFieldFactory(IStaticClassField field)
            : base(field)
        {
        }

        public override void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            Value = new StaticClassField()
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
