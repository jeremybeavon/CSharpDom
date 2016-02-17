using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedEnumWithReflection :
        AbstractStaticClassNestedEnum<
            AttributeWithReflection,
            ITypeWithReflection,
            NestedEnumMemberWithReflection>
    {
        private readonly NestedEnumWithReflection nestedEnum;

        internal StaticClassNestedEnumWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedEnum = new NestedEnumWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedEnum.Attributes; }
        }

        public override EnumBaseType BaseType
        {
            get { return nestedEnum.BaseType; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return nestedEnum.DeclaringType; }
        }

        public override IReadOnlyList<NestedEnumMemberWithReflection> EnumMembers
        {
            get { return nestedEnum.EnumMembers; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return nestedEnum.Type.StaticClassMemberVisibility(); }
        }
    }
}
