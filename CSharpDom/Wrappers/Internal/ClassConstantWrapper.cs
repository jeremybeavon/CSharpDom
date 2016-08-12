using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassConstantWrapper : AbstractWrapper<IClassConstant>
    {
        public ClassConstantWrapper(IClassConstant field)
            : base(field)
        {
        }

        public override void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            Value = new ClassConstant()
            {
                Attributes = field.Attributes.ToAttributeListUsingWrapper(),
                Constants = field.Constants.ToList(child => new ConstantWrapper(child).Value),
                FieldType = new TypeReferenceWrapper(field.FieldType).Value,
                Visibility = field.Visibility
            };
        }
    }
}
