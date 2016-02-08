using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceAccessorWithReflection :
        AbstractInterfaceAccessor<AttributeWithReflection>
    {
        private readonly Lazy<Attributes> attributes;

        internal InterfaceAccessorWithReflection(MethodInfo method)
        {
            attributes = new Lazy<Attributes>(() => new Attributes(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }
    }
}
