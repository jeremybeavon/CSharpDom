using CSharpDom.BaseClasses;
using System.Reflection;
using System;
using System.Collections.Generic;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class EnumMemberWithReflection : AbstractEnumMember<AttributeWithReflection, EnumWithReflection>, IHasFieldInfo
    {
        private readonly EnumWithReflection declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;

        internal EnumMemberWithReflection(EnumWithReflection declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override EnumWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        public FieldInfo FieldInfo
        {
            get { return field; }
        }
    }
}
