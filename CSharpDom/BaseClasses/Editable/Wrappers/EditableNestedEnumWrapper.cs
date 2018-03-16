using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableNestedEnumWrapper<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        EditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IWrapper<IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableType
        where TNestedEnumMember : IEditableNestedEnumMember
    {
        public EditableNestedEnumWrapper(IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            WrappedObject = nestedEnum;
        }

        public override ICollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
            set { WrappedObject.Attributes = value; }
        }

        public override EnumBaseType BaseType
        {
            get { return WrappedObject.BaseType; }
            set { WrappedObject.BaseType = value; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
            set { WrappedObject.DeclaringType = value; }
        }

        public override IList<TNestedEnumMember> EnumMembers
        {
            get { return WrappedObject.EnumMembers; }
            set { WrappedObject.EnumMembers = value; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
            set { WrappedObject.Name = value; }
        }

        public IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> WrappedObject { get; private set; }
    }
}