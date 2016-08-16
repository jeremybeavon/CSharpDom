using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableAbstractAccessor<TAttributeGroup> : 
        EditableAccessor<TAttributeGroup>,
        IAbstractAccessor<TAttributeGroup>
        where TAttributeGroup : IAttributeGroup
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractAccessorChildren(this, visitor);
        }
    }
}
