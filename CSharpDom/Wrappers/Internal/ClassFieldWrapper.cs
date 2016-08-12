using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassFieldWrapper : AbstractWrapper<IClassField>
    {
        public ClassFieldWrapper(IClassField field)
            : base(field)
        {
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Value = new ClassField()
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
