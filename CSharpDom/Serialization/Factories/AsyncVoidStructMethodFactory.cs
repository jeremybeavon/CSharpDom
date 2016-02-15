using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncVoidStructMethodFactory : AbstractFactory<IAsyncVoidStructMethod, AsyncVoidStructMethod>
    {
        public AsyncVoidStructMethodFactory(IAsyncVoidStructMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncVoidStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(
            IAsyncVoidStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
        {
            Value = new AsyncVoidStructMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                Visibility = method.Visibility
            };
        }
    }
}
