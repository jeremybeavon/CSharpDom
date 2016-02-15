using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractExtensionMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TExtensionParameter,
        TParameter,
        TMethodBody> :
        AbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>
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
            visitor.VisitExtensionMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExtensionMethodChildren(this, visitor);
        }
    }
}
