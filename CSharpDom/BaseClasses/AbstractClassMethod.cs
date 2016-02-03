﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> :
        AbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>,
        IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TGenericParameter : IGenericParameterDeclaration
        where TTypeReference : ITypeReference
        where TParameter : IParameter
        where TMethodBody : IMethodBody
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; }
        
        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassMethod(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}
