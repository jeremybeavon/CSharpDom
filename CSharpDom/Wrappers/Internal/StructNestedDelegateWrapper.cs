using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructNestedDelegateWrapper : AbstractWrapper<IStructNestedDelegate>
    {
        public StructNestedDelegateWrapper(IStructNestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new StructNestedDelegate()
            {
                Attributes = nestedDelegate.Attributes.ToAttributeListUsingWrapper(),
                GenericParameters = nestedDelegate.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                Name = nestedDelegate.Name,
                Parameters = nestedDelegate.Parameters.ToList(parameter => new DelegateParameterWrapper(parameter).Value),
                ReturnType = new TypeReferenceWrapper(nestedDelegate.ReturnType).Value,
                Visibility = nestedDelegate.Visibility
            };
        }
    }
}
