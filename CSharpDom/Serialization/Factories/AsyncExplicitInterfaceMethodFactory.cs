using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncExplicitInterfaceMethodFactory : AbstractFactory<IAsyncExplicitInterfaceMethod, AsyncExplicitInterfaceMethod>
    {
        public AsyncExplicitInterfaceMethodFactory(IAsyncExplicitInterfaceMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IAsyncExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new AsyncExplicitInterfaceMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                ExplicitInterface = new InterfaceReferenceFactory(method.ExplicitInterface).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                TaskGenericParameter = new TypeReferenceFactory(method.TaskGenericParameter).Value
            };
        }
    }
}
