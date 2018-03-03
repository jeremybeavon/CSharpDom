using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAbstractAccessor<TAttributeGroup> : 
        EditableAccessor<TAttributeGroup>,
        IEditableAbstractAccessor<TAttributeGroup>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public abstract AbstractAccessorVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractAccessorChildren(this, visitor);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitAbstractAccessor(this);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
