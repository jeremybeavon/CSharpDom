using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassConstantWrapper : AbstractWrapper<IStaticClassConstant>
    {
        public StaticClassConstantWrapper(IStaticClassConstant field)
            : base(field)
        {
        }

        public override void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            Value = new StaticClassConstant()
            {
                Attributes = field.Attributes.ToAttributeListUsingWrapper(),
                Constants = field.Constants.ToList(child => new ConstantWrapper(child).Value),
                FieldType = new TypeReferenceWrapper(field.FieldType).Value,
                Visibility = field.Visibility
            };
        }
    }
}
