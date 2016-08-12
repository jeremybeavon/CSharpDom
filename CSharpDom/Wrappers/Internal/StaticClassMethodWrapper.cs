using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassMethodWrapper : AbstractWrapper<IStaticClassMethod>
    {
        public StaticClassMethodWrapper(IStaticClassMethod method)
            : base(method)
        {
        }

        public override void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new StaticClassMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                IsAsync = method.IsAsync,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterWrapper(parameter).Value),
                ReturnAttributes = method.ReturnAttributes.ToAttributeListUsingWrapper(),
                ReturnType = new TypeReferenceWrapper(method.ReturnType).Value,
                Visibility = method.Visibility
            };
        }
    }
}
