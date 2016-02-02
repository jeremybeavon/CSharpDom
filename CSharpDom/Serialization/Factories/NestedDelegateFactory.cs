using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class NestedDelegateFactory : AbstractFactory<IClassNestedDelegate, ClassNestedDelegate>
    {
        public NestedDelegateFactory(IClassNestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new ClassNestedDelegate()
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
