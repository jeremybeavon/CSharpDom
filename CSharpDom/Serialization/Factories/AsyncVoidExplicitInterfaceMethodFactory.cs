using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncVoidExplicitInterfaceMethodFactory : AbstractFactory<IAsyncVoidExplicitInterfaceMethod, AsyncVoidExplicitInterfaceMethod>
    {
        public AsyncVoidExplicitInterfaceMethodFactory(IAsyncVoidExplicitInterfaceMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncVoidExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TParameter, TMethodBody>(
            IAsyncVoidExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TParameter, TMethodBody> method)
        {
            Value = new AsyncVoidExplicitInterfaceMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                ExplicitInterface = new InterfaceReferenceFactory(method.ExplicitInterface).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value)
            };
        }
    }
}
