using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceMethodFactory : AbstractFactory<IInterfaceMethod, InterfaceMethod>
    {
        public InterfaceMethodFactory(IInterfaceMethod method)
            : base(method)
        {
        }

        public override void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Value = new InterfaceMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                InheritanceModifier = method.InheritanceModifier,
                Name = method.Name,
                Parameters = method.Parameters.ToParameterListUsingFactory(),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value
            };
        }
    }
}
