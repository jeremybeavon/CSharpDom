using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedDelegateFactory : AbstractFactory<INestedDelegate, NestedDelegate>
    {
        public NestedDelegateFactory(INestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new NestedDelegate()
            {
                Attributes = nestedDelegate.Attributes.ToAttributeListUsingFactory(),
                GenericParameters = nestedDelegate.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = nestedDelegate.Name,
                Parameters = nestedDelegate.Parameters.ToParameterListUsingFactory(),
                ReturnType = new TypeReferenceFactory(nestedDelegate.ReturnType).Value,
                Visibility = nestedDelegate.Visibility
            };
        }
    }
}
