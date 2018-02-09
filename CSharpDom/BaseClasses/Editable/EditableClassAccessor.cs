using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassAccessor<TAttributeGroup, TMethodBody> :
        EditableAccessor<TAttributeGroup, TMethodBody>,
        IEditableClassAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IEditableAttributeGroup
        where TMethodBody : IEditableMethodBody
    {
        public abstract ClassAccessorVisibilityModifier Visibility { get; set; }

        public sealed override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAccessor(this);
        }
    }
}
