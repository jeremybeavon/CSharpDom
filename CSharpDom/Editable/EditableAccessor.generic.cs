using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableAccessor<TAttributeGroup> : IAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        public virtual void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
