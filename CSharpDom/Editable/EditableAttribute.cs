using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> :
        IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>
        where TClassReference : IClassReference
        where TUnnamedAttributeValue : IUnnamedAttributeValue
        where TNamedAttributeValue : INamedAttributeValue
    {
        public virtual TClassReference AttributeType { get; set; }

        public virtual IReadOnlyCollection<TNamedAttributeValue> NamedValues { get; set; }

        public virtual IReadOnlyList<TUnnamedAttributeValue> UnnamedValues { get; set; }

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
