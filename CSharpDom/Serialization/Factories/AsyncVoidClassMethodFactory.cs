using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncVoidClassMethodFactory : AbstractFactory<IAsyncVoidClassMethod, AsyncVoidClassMethod>
    {
        public AsyncVoidClassMethodFactory(IAsyncVoidClassMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncVoidClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(
            IAsyncVoidClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
        {
            Value = new AsyncVoidClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                InheritanceModifier = method.InheritanceModifier,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                Visibility = method.Visibility
            };
        }
    }
}
