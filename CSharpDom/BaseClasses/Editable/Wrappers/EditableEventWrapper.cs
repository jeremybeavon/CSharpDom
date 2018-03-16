using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableEventWrapper<TAttributeGroup, TDeclaringType, TDelegateReference> :
        EditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>,
        IWrapper<IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TDelegateReference : IEditableDelegateReference
    {
        public EditableEventWrapper(IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            WrappedObject = @event;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override TDelegateReference EventType
        {
            get { return WrappedObject.EventType; }
            set { WrappedObject.EventType = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference> WrappedObject { get; private set; }
    }
}