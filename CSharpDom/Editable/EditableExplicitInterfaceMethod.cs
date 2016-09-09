using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableExplicitInterfaceMethod<
        TAttributeGroup,
        TDeclaringType,
        TInterfaceReference,
        TGenericParameter,
        TTypeReference,
        TParameter,
        TMethodBody> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TInterfaceReference : IInterfaceReference
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public abstract TInterfaceReference ExplicitInterface { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExplicitInterfaceMethodChildren(this, visitor);
        }
    }
}
