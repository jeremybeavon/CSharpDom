using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncStructMethodFactory : AbstractFactory<IAsyncStructMethod, AsyncStructMethod>
    {
        public AsyncStructMethodFactory(IAsyncStructMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IAsyncStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new AsyncStructMethod()
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
