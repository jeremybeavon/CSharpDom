﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        EditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IMethodParameter
        where TMethodBody : IMethodBody
    {
        public virtual StructMemberInheritanceModifier InheritanceModifier { get; set; }

        public virtual StructMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructMethodChildren(this, visitor);
        }
    }
}
