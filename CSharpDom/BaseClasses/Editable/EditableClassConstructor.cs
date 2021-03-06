﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Wrappers;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> :
        EditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>,
        IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TParameter : IConstructorParameter
        where TMethodBody : IMethodBody
    {
        public abstract ClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassConstructor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassConstructorChildren(this, visitor);
        }
    }
}
