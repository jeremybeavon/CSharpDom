using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructConstantWrapper : AbstractWrapper<IStructConstant>
    {
        public StructConstantWrapper(IStructConstant field)
            : base(field)
        {
        }

        public override void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            Value = new StructConstant()
            {
                Attributes = field.Attributes.ToAttributeListUsingWrapper(),
                Constants = field.Constants.ToList(child => new ConstantWrapper(child).Value),
                FieldType = new TypeReferenceWrapper(field.FieldType).Value,
                Visibility = field.Visibility
            };
        }
    }
}
