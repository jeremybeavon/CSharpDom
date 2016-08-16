using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAccessor<TAttributeGroup> : IAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

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
