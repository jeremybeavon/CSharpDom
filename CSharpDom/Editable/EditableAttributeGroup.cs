using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableAttributeGroup<TAttribute> : IAttributeGroup<TAttribute>
        where TAttribute : IAttribute
    {
        public virtual ICollection<TAttribute> Attributes { get; set; }

        IReadOnlyCollection<TAttribute> IHasAttributes<TAttribute>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttribute>(Attributes); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAttributeGroup(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAttributeGroupChildren(this, visitor);
        }
    }
}
