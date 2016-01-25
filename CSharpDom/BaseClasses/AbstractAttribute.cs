using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> :
        IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>
        where TClassReference : IClassReference
        where TUnnamedAttributeValue : IUnnamedAttributeValue
        where TNamedAttributeValue : INamedAttributeValue
    {
        public abstract TClassReference AttributeType { get; }

        public abstract IReadOnlyCollection<TNamedAttributeValue> NamedValues { get; }

        public abstract IReadOnlyList<TUnnamedAttributeValue> UnnamedValues { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttribute(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeChildren(this, visitor);
        }
    }
}
