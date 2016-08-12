using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExtensionMethodWrapper : AbstractWrapper<IExtensionMethod>
    {
        public ExtensionMethodWrapper(IExtensionMethod method)
            : base(method)
        {
        }

        public override void VisitExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
        {
            Value = new ExtensionMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(method.Body).Value,
                ExtensionParameter = new ExtensionParameterWrapper(method.ExtensionParameter).Value,
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
