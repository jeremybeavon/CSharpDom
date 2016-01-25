using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public abstract class AbstractEnumMemberWithReflection<TDeclaringType> :
        AbstractEnumMember<AttributeWithReflection, TDeclaringType>
    {
        private readonly TDeclaringType declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;

        protected AbstractEnumMemberWithReflection(TDeclaringType declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return declaringType; }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
