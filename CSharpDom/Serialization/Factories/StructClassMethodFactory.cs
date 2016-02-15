using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructMethodFactory : AbstractFactory<IStructMethod, StructMethod>
    {
        public StructMethodFactory(IStructMethod method)
            : base(method)
        {
        }

        public override void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new StructMethod()
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
