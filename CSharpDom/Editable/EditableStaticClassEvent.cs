﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TDelegateReference : IDelegateReference
    {
        public virtual ICollection<TAttributeGroup> FieldAttributes { get; set; }

        public virtual StaticClassMemberVisibilityModifier Visibility { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasFieldAttributes<TAttributeGroup>.FieldAttributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(FieldAttributes); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEvent(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassEventChildren(this, visitor);
        }
    }
}