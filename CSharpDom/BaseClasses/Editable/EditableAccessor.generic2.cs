using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup>,
        IEditableAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TMethodBody : IEditableMethodBody
    {
        public abstract TMethodBody Body { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAccessor(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAccessorChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
