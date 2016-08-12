using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassFieldWrapper : AbstractWrapper<IStaticClassField>
    {
        public StaticClassFieldWrapper(IStaticClassField field)
            : base(field)
        {
        }

        public override void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field> field)
        {
            Value = new StaticClassField()
            {
                Attributes = field.Attributes.ToAttributeListUsingWrapper(),
                Fields = field.Fields.ToList(child => new FieldWrapper(child).Value),
                FieldType = new TypeReferenceWrapper(field.FieldType).Value,
                Modifier = field.Modifier,
                Visibility = field.Visibility
            };
        }
    }
}
