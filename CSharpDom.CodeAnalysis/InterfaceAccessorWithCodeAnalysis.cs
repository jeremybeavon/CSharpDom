using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceAccessorWithCodeAnalysis :
        AbstractInterfaceAccessor<AttributeGroupWithCodeAnalysis>
    {
        private readonly Lazy<Attributes> attributes;

        internal InterfaceAccessorWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, MethodDefinition method)
        {
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }
    }
}
