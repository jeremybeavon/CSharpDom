using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceAccessorWithMonoCecil :
        AbstractInterfaceAccessor<AttributeWithMonoCecil>
    {
        private readonly Lazy<Attributes> attributes;

        internal InterfaceAccessorWithMonoCecil(AssemblyWithMonoCecil assembly, MethodDefinition method)
        {
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }
    }
}
