using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassNestedDelegateWrapper : AbstractWrapper<IClassNestedDelegate>
    {
        public ClassNestedDelegateWrapper(IClassNestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new ClassNestedDelegate()
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
