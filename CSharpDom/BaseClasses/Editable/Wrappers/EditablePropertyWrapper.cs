using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditablePropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> :
        EditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IWrapper<IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAccessor
    {
        public EditablePropertyWrapper(IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            WrappedObject = property;
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

        public override TAccessor GetAccessor
        {
            get { return WrappedObject.GetAccessor; }
            set { WrappedObject.GetAccessor = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public override TTypeReference PropertyType
        {
            get { return WrappedObject.PropertyType; }
            set { WrappedObject.PropertyType = value; }
        }

        public override TAccessor SetAccessor
        {
            get { return WrappedObject.SetAccessor; }
            set { WrappedObject.SetAccessor = value; }
        }

        public IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> WrappedObject { get; private set; }
    }
}