using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructMethodWrapper : AbstractWrapper<IStructMethod>
    {
        public StructMethodWrapper(IStructMethod method)
            : base(method)
        {
        }

        public override void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            Value = new StructMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                Body = new MethodBodyWrapper(method.Body).Value,
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                InheritanceModifier = method.InheritanceModifier,
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
