using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassFieldFactory : AbstractFactory<ISealedClassField, SealedClassField>
    {
        public SealedClassFieldFactory(ISealedClassField field)
            : base(field)
        {
        }

        public override void VisitSealedClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            ISealedClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            Value = new SealedClassField()
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
