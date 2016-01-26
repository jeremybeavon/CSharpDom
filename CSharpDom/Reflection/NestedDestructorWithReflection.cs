using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class NestedDestructorWithReflection :
        AbstractNestedDestructor<AttributeWithReflection, NestedClassWithReflection>
    {
        private readonly NestedClassWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;

        internal NestedDestructorWithReflection(NestedClassWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override NestedClassWithReflection DeclaringType
        {
            get { return declaringType; }
        }
    }
}
