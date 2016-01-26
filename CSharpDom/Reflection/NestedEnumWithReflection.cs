using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Linq;

namespace CSharpDom.Reflection
{
    public sealed class NestedEnumWithReflection :
        AbstractNestedEnum<AttributeWithReflection, ITypeWithReflection, NestedEnumMemberWithReflection>,
        IHasType
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyCollection<NestedEnumMemberWithReflection>> enumMembers;

        internal NestedEnumWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            enumMembers = new Lazy<IReadOnlyCollection<NestedEnumMemberWithReflection>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyCollection<NestedEnumMemberWithReflection> EnumMembers
        {
            get { return enumMembers.Value; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return type.NestedVisibility(); }
        }

        public Type Type
        {
            get { return type; }
        }

        private IReadOnlyCollection<NestedEnumMemberWithReflection> InitializeEnumMembers()
        {
            return type.GetAllFields().Select(field => new NestedEnumMemberWithReflection(this, field)).ToList();
        }
    }
}
