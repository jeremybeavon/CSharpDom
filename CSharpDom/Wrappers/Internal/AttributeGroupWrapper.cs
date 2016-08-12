using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AttributeGroupWrapper : AbstractWrapper<IAttributeGroup>, IAttributeGroupWrapper
    {
        private Func<IReadOnlyCollection<IAttributeWrapper>> attributes;

        public AttributeGroupWrapper(IAttributeGroup attributeGroup)
            : base(attributeGroup)
        {
        }

        public IReadOnlyCollection<IAttributeWrapper> Attributes
        {
            get { return attributes(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttributeGroup(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeGroupChildren(this, visitor);
        }

        public override void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
        {
            this.attributes = () => new ReadOnlyCollectionWrapper<TAttribute, IAttributeWrapper>(
                attributes.Attributes,
                input => new AttributeWrapper(input));
        }
    }
}
