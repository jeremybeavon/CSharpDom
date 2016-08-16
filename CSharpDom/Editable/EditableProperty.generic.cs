﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TDeclaringType DeclaringType { get; set; }

        public virtual TAccessor GetAccessor { get; set; }

        public virtual string Name { get; set; }

        public virtual TTypeReference PropertyType { get; set; }

        public virtual TAccessor SetAccessor { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProperty(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
