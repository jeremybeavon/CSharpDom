using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncVoidSealedClassMethodFactory : AbstractFactory<IAsyncVoidSealedClassMethod, AsyncVoidSealedClassMethod>
    {
        public AsyncVoidSealedClassMethodFactory(IAsyncVoidSealedClassMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncVoidSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(
            IAsyncVoidSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
        {
            Value = new AsyncVoidSealedClassMethod()
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
