using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ClassNestedDelegateFactory : AbstractFactory<IClassNestedDelegate, ClassNestedDelegate>
    {
        public ClassNestedDelegateFactory(IClassNestedDelegate nestedDelegate)
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
                Parameters = nestedDelegate.Parameters.ToList(parameter => new DelegateParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(nestedDelegate.ReturnType).Value,
                Visibility = nestedDelegate.Visibility
            };
        }
    }
}
