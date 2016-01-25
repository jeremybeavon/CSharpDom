using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class NestedEnumMemberWithReflection : AbstractEnumMember<AttributeWithReflection, NestedEnumWithReflection>
    {
        private readonly NestedEnumWithReflection declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;

        internal NestedEnumMemberWithReflection(NestedEnumWithReflection declaringType, FieldInfo field)
            : base(declaringType, field)
        {
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override NestedEnumWithReflection DeclaringType
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
    }
}
