using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructFieldWrapper : AbstractWrapper<IStructField>
    {
        public StructFieldWrapper(IStructField field)
            : base(field)
        {
        }

        public override void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            Value = new StructField()
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
