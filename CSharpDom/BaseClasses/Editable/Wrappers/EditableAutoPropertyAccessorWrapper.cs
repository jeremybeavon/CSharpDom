using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableAutoPropertyAccessorWrapper<TAttributeGroup> :
        EditableAutoPropertyAccessor<TAttributeGroup>,
        IWrapper<IEditableAutoPropertyAccessor<TAttributeGroup>>
        where TAttributeGroup : IEditableAttributeGroup
    {
        public EditableAutoPropertyAccessorWrapper(IEditableAutoPropertyAccessor<TAttributeGroup> accessor)
        {
            WrappedObject = accessor;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public IEditableAutoPropertyAccessor<TAttributeGroup> WrappedObject { get; private set; }
    }
}