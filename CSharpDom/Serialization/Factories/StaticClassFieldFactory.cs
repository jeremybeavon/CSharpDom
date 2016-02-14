using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassFieldFactory : AbstractFactory<IStaticClassField, StaticClassField>
    {
        public StaticClassFieldFactory(IStaticClassField field)
            : base(field)
        {
        }

        public override void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field> field)
        {
            Value = new StaticClassField()
            {
                Attributes = field.Attributes.ToAttributeListUsingFactory(),
                Fields = field.Fields.ToList(child => new FieldFactory(child).Value),
                FieldType = new TypeReferenceFactory(field.FieldType).Value,
                Modifier = field.Modifier,
                InheritanceModifier = field.InheritanceModifier
            };
        }
    }
}
