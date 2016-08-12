using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceMethodWrapper : AbstractWrapper<IInterfaceMethod>
    {
        public InterfaceMethodWrapper(IInterfaceMethod method)
            : base(method)
        {
        }

        public override void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            Value = new InterfaceMethod()
            {
                Attributes = method.Attributes.ToAttributeListUsingWrapper(),
                GenericParameters = method.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                InheritanceModifier = method.InheritanceModifier,
                Name = method.Name,
                Parameters = method.Parameters.ToList(parameter => new MethodParameterWrapper(parameter).Value),
                ReturnAttributes = method.ReturnAttributes.ToAttributeListUsingWrapper(),
                ReturnType = new TypeReferenceWrapper(method.ReturnType).Value
            };
        }
    }
}
