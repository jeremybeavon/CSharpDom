using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableInterfaceMethod<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TParameter> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IInterfaceType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
    {
        public abstract InterfaceMemberInheritanceModifier InheritanceModifier { get; set; }

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
