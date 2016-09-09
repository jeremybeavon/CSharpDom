using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup>,
        IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
        public abstract TMethodBody Body { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAccessor(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAccessor(this, visitor);
        }
    }
}
