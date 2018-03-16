using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableConstantGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        EditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IWrapper<IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TTypeReference : IEditableTypeReference
        where TConstant : IEditableConstant
    {
        public EditableConstantGroupWrapper(IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
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

        public override ICollection<TConstant> Constants
        {
            get { return WrappedObject.Constants; }
            set { WrappedObject.Constants = value; }
        }

        public override TTypeReference FieldType
        {
            get { return WrappedObject.FieldType; }
            set { WrappedObject.FieldType = value; }
        }

        public IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> WrappedObject { get; private set; }
    }
}