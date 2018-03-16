using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableEventPropertyWrapper<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IWrapper<IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TDelegateReference : IEditableDelegateReference
        where TMethodBody : IEditableMethodBody
    {
        public EditableEventPropertyWrapper(IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> @event)
        {
            WrappedObject = @event;
        }

        public override ICollection<TAttributeGroup> AddAttributes
        {
            get { return WrappedObject.AddAttributes; }
            set { WrappedObject.AddAttributes = value; }
        }

        public override TMethodBody AddBody
        {
            get { return WrappedObject.AddBody; }
            set { WrappedObject.AddBody = value; }
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

        public override ICollection<TAttributeGroup> RemoveAttributes
        {
            get { return WrappedObject.RemoveAttributes; }
            set { WrappedObject.RemoveAttributes = value; }
        }

        public override TMethodBody RemoveBody
        {
            get { return WrappedObject.RemoveBody; }
            set { WrappedObject.RemoveBody = value; }
        }

        public IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> WrappedObject { get; private set; }
    }
}