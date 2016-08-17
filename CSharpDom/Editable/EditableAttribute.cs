using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public class EditableAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> :
        IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>
        where TClassReference : IClassReference
        where TUnnamedAttributeValue : IUnnamedAttributeValue
        where TNamedAttributeValue : INamedAttributeValue
    {
        public virtual TClassReference AttributeType { get; set; }

        public virtual ICollection<TNamedAttributeValue> NamedValues { get; set; }

        public virtual IList<TUnnamedAttributeValue> UnnamedValues { get; set; }

        IReadOnlyCollection<TNamedAttributeValue> IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>.NamedValues
        {
            get { return new ReadOnlyCollectionWrapper<TNamedAttributeValue>(NamedValues); }
        }

        IReadOnlyList<TUnnamedAttributeValue> IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>.UnnamedValues
        {
            get { return new ReadOnlyCollection<TUnnamedAttributeValue>(UnnamedValues); }
        }

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
