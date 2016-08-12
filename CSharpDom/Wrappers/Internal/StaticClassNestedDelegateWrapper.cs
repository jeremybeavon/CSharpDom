using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassNestedDelegateWrapper : AbstractWrapper<IStaticClassNestedDelegate>
    {
        public StaticClassNestedDelegateWrapper(IStaticClassNestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new StaticClassNestedDelegate()
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
