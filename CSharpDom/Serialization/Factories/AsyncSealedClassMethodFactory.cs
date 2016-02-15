using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AsyncSealedClassMethodFactory : AbstractFactory<IAsyncSealedClassMethod, AsyncSealedClassMethod>
    {
        public AsyncSealedClassMethodFactory(IAsyncSealedClassMethod method)
            : base(method)
        {
        }

        public override void VisitAsyncSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IAsyncSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new AsyncSealedClassMethod()
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
