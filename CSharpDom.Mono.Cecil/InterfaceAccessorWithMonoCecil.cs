using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceAccessorWithMonoCecil :
        AbstractInterfaceAccessor<AttributeWithMonoCecil>
    {
        private readonly Lazy<Attributes> attributes;

        internal InterfaceAccessorWithMonoCecil(MethodInfo method)
        {
            attributes = new Lazy<Attributes>(() => new Attributes(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }
    }
}
