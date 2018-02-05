using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAbstractAccessor<TAttributeGroup> : 
        EditableAccessor<TAttributeGroup>,
        IAbstractAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
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
