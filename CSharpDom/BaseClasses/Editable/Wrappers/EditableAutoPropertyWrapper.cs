using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableAutoPropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        EditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        IWrapper<IEditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableBasicType
        where TTypeReference : IEditableTypeReference
        where TAccessor : IEditableAutoPropertyAccessor
        where TExpression : IEditableExpression
    {
        public EditableAutoPropertyWrapper(IEditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
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

        public IEditableAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> WrappedObject { get; private set; }

        public override TExpression InitialValue
        {
            get => WrappedObject.InitialValue;
            set => WrappedObject.InitialValue = value;
        }
    }
}