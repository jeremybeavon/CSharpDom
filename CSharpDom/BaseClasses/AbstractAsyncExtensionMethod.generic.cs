using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAsyncExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> :
        AbstractAsyncMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IAsyncExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticClass
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TExtensionParameter : IExtensionParameter
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract TExtensionParameter ExtensionParameter { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAsyncExtensionMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAsyncExtensionMethodChildren(this, visitor);
        }
    }
}
