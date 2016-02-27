using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class NestedEnumWrapper<TAttributeGroup, TDeclaringType, TNestedEnumMember> :
        AbstractNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>,
        IWrapper<INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TNestedEnumMember : INestedEnumMember
    {
        public NestedEnumWrapper(INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            WrappedObject = nestedEnum;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override EnumBaseType BaseType
        {
            get { return WrappedObject.BaseType; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override IReadOnlyList<TNestedEnumMember> EnumMembers
        {
            get { return WrappedObject.EnumMembers; }
        }

        public override string Name
        {
            get { return WrappedObject.Name; }
        }

        public INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> WrappedObject { get; private set; }
    }
}
