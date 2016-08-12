using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AttributeWrapper : AbstractWrapper<IAttribute>, IAttributeWrapper
    {
        private Func<IClassReferenceWrapper> attributeType;
        private Func<IReadOnlyCollection<INamedAttributeValueWrapper>> namedValues;
        private Func<IReadOnlyList<IUnnamedAttributeValueWrapper>> unnamedValues;

        public AttributeWrapper(IAttribute attribute)
            : base(attribute)
        {
        }

        public IClassReferenceWrapper AttributeType
        {
            get { return attributeType(); }
        }

        public IReadOnlyCollection<INamedAttributeValueWrapper> NamedValues
        {
            get { return namedValues(); }
        }

        public IReadOnlyList<IUnnamedAttributeValueWrapper> UnnamedValues
        {
            get { return unnamedValues(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttribute(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeChildren(this, visitor);
        }

        public override void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
        {
            attributeType = () => new ClassReferenceWrapper(attribute.AttributeType);
            namedValues = () => new ReadOnlyCollectionWrapper<TNamedAttributeValue, INamedAttributeValueWrapper>(
                attribute.NamedValues,
                input => new NamedAttributeValueWrapper(input));
            unnamedValues = () => new ReadOnlyListWrapper<TUnnamedAttributeValue, IUnnamedAttributeValueWrapper>(
                attribute.UnnamedValues,
                input => new UnnamedAttributeValueWrapper(input));
        }
    }
}
