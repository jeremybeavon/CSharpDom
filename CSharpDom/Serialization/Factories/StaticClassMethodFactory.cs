using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StaticClassMethodFactory : AbstractFactory<IStaticClassMethod, StaticClassMethod>
    {
        public StaticClassMethodFactory(IStaticClassMethod method)
            : base(method)
        {
        }

        public override void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new StaticClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value,
                InheritanceModifier = method.InheritanceModifier
            };
        }
    }
}
