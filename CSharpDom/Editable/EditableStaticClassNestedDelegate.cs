﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassNestedDelegate<
        TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TTypeReference,
        TParameter> :
        EditableNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>,
        IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IDelegateParameter
    {
        public virtual ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedDelegate(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedDelegateChildren(this, visitor);
        }
    }
}