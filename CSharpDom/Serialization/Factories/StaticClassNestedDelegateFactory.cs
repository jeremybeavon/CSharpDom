using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassNestedDelegateFactory : AbstractFactory<IStaticClassNestedDelegate, StaticClassNestedDelegate>
    {
        public StaticClassNestedDelegateFactory(IStaticClassNestedDelegate nestedDelegate)
            : base(nestedDelegate)
        {
        }

        public override void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            Value = new StaticClassNestedDelegate()
            {
                Attributes = nestedDelegate.Attributes.ToAttributeListUsingFactory(),
                GenericParameters = nestedDelegate.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = nestedDelegate.Name,
                Parameters = nestedDelegate.Parameters.ToList(parameter => new DelegateParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(nestedDelegate.ReturnType).Value,
                Visibility = nestedDelegate.Visibility
            };
        }
    }
}
