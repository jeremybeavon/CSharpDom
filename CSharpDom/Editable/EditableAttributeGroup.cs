using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAttributeGroup<TAttribute> : IAttributeGroup<TAttribute>
        where TAttribute : IAttribute
    {
        public virtual IReadOnlyCollection<TAttribute> Attributes { get; set; }

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
