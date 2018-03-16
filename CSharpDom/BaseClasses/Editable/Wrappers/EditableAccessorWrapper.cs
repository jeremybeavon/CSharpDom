using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableAccessorWrapper<TAttributeGroup> :
        EditableAccessor<TAttributeGroup>,
        IWrapper<IEditableAccessor<TAttributeGroup>>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public EditableAccessorWrapper(IEditableAccessor<TAttributeGroup> accessor)
        {
            WrappedObject = accessor;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public IEditableAccessor<TAttributeGroup> WrappedObject { get; private set; }
    }
}