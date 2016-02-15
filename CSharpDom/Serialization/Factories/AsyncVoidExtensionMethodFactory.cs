using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncVoidExtensionMethodFactory : AbstractFactory<IAsyncVoidExtensionMethod, AsyncVoidExtensionMethod>
    {
        public AsyncVoidExtensionMethodFactory(IAsyncVoidExtensionMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncVoidExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TExtensionParameter, TParameter, TMethodBody>(
            IAsyncVoidExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TExtensionParameter, TParameter, TMethodBody> method)
        {
            Value = new AsyncVoidExtensionMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                ExtensionParameter = new ExtensionParameterFactory(method.ExtensionParameter).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value)
            };
        }
    }
}
