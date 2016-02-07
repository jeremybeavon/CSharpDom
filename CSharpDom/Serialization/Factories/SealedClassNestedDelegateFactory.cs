using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassNestedDelegateFactory : AbstractFactory<ISealedClassNestedDelegate, SealedClassNestedDelegate>
    {
        public SealedClassNestedDelegateFactory(ISealedClassNestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitSealedClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            ISealedClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new SealedClassNestedDelegate()
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
