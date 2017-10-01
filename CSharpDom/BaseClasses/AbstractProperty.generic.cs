using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        AbstractGenericVisitableObject,
        IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAccessor
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract TAccessor GetAccessor { get; }

        public abstract string Name { get; }

        public abstract TTypeReference PropertyType { get; }

        public abstract TAccessor SetAccessor { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitPropertyChildren(this, visitor);
        }
    }
}
