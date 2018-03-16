using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableFieldGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        EditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IWrapper<IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TField : IEditableField
    {
        public EditableFieldGroupWrapper(IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            WrappedObject = field;
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

        public override ICollection<TField> Fields
        {
            get { return WrappedObject.Fields; }
            set { WrappedObject.Fields = value; }
        }

        public override TTypeReference FieldType
        {
            get { return WrappedObject.FieldType; }
            set { WrappedObject.FieldType = value; }
        }

        public IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> WrappedObject { get; private set; }
    }
}