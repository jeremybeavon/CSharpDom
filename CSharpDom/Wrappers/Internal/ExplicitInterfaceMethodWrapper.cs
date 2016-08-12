using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfaceMethodWrapper : AbstractWrapper<IExplicitInterfaceMethod>
    {
        public ExplicitInterfaceMethodWrapper(IExplicitInterfaceMethod method)
            : base(method)
        {
        }

        public override void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new ExplicitInterfaceMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(method.Body).Value,
                ExplicitInterface = new InterfaceReferenceWrapper(method.ExplicitInterface).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                IsAsync = method.IsAsync,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterWrapper(parameter).Value),
                ReturnAttributes = method.ReturnAttributes.ToAttributeListUsingWrapper(),
                ReturnType = new TypeReferenceWrapper(method.ReturnType).Value
            };
        }
    }
}
