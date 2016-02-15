using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AbstractMethodFactory : AbstractFactory<IAbstractMethod, AbstractMethod>
    {
        public AbstractMethodFactory(IAbstractMethod method)
            : base(method)
        {
        }

        public override void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Value = new AbstractMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value
            };
        }
    }
}
