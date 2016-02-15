using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncExtensionMethodFactory : AbstractFactory<IAsyncExtensionMethod, AsyncExtensionMethod>
    {
        public AsyncExtensionMethodFactory(IAsyncExtensionMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IAsyncExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
        {
            Value = new AsyncExtensionMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                ExtensionParameter = new ExtensionParameterFactory(method.ExtensionParameter).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                TaskGenericParameter = new TypeReferenceFactory(method.TaskGenericParameter).Value
            };
        }
    }
}
