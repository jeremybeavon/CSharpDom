using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedEnumWithReflection :
        AbstractStructNestedEnum<
            AttributeWithReflection,
            ITypeWithReflection,
            NestedEnumMemberWithReflection>
    {
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<NestedEnumMemberWithReflection> EnumMembers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
