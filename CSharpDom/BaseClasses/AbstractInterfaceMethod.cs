using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractInterfaceMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TParameter> :
        AbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitInterfaceMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitInterfaceMethodChildren(this, visitor);
        }
    }
}
