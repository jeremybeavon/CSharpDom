using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class SealedClassMethodFactory : AbstractFactory<ISealedClassMethod, SealedClassMethod>
    {
        public SealedClassMethodFactory(ISealedClassMethod method)
            : base(method)
        {
        }

        public override void VisitSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new SealedClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                ReturnType = new TypeReferenceFactory(method.ReturnType).Value,
                Visibility = method.Visibility
            };
        }
    }
}
