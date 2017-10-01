using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable
{
    public abstract class EditableAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> :
        AbstractGenericVisitableObject,
        IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>
        where TClassReference : IClassReference
        where TUnnamedAttributeValue : IUnnamedAttributeValue
        where TNamedAttributeValue : INamedAttributeValue
    {
        public abstract TClassReference AttributeType { get; set; }

        public abstract ICollection<TNamedAttributeValue> NamedValues { get; set; }

        public abstract IList<TUnnamedAttributeValue> UnnamedValues { get; set; }

        IReadOnlyCollection<TNamedAttributeValue> IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>.NamedValues
        {
            get { return new ReadOnlyCollectionWrapper<TNamedAttributeValue>(NamedValues); }
        }

        IReadOnlyList<TUnnamedAttributeValue> IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>.UnnamedValues
        {
            get { return new ReadOnlyCollection<TUnnamedAttributeValue>(UnnamedValues); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttribute(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeChildren(this, visitor);
        }
    }
}
