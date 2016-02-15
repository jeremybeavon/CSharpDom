using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncStaticClassMethodFactory : AbstractFactory<IAsyncStaticClassMethod, AsyncStaticClassMethod>
    {
        public AsyncStaticClassMethodFactory(IAsyncStaticClassMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IAsyncStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new AsyncStaticClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                TaskGenericParameter = new TypeReferenceFactory(method.TaskGenericParameter).Value,
                Visibility = method.Visibility
            };
        }
        
    }
}
