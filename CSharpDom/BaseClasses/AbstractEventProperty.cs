﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference> : 
        IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TDelegateReference : IDelegateReference
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TDelegateReference EventType { get; }

        public abstract MemberInheritanceModifier InheritanceModifier { get; }

        public abstract string Name { get; }

        public abstract MemberVisibilityModifier Visibility { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitEventProperty(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitEventPropertyChildren(this, visitor);
        }
    }
}
