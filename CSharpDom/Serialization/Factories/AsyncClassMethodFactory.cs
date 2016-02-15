using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncClassMethodFactory : AbstractFactory<IAsyncClassMethod, AsyncClassMethod>
    {
        public AsyncClassMethodFactory(IAsyncClassMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IAsyncClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new AsyncClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingFactory(),
                Body = new MethodBodyFactory(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingFactory(),
                InheritanceModifier = method.InheritanceModifier,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterFactory(parameter).Value),
                TaskGenericParameter = new TypeReferenceFactory(method.TaskGenericParameter).Value,
                Visibility = method.Visibility
            };
        }
    }
}
