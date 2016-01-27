using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class NestedEnumMemberWithReflection :
        AbstractNestedEnumMember<AttributeWithReflection, NestedEnumWithReflection>,
        IVisitable<IReflectionVisitor>
    {
        private readonly NestedEnumWithReflection declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;

        internal NestedEnumMemberWithReflection(NestedEnumWithReflection declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override NestedEnumWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumMemberWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
