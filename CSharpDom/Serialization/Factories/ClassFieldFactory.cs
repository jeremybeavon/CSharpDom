using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassFieldFactory : AbstractFactory<IClassField, ClassField>
    {
        public ClassFieldFactory(IClassField field)
            : base(field)
        {
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Value = new ClassField()
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
