using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AccessorWithMonoCecil :
        AbstractAccessor<AttributeWithMonoCecil, ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        internal AccessorWithMonoCecil(AssemblyWithMonoCecil assembly, MethodDefinition method)
        {
            MethodDefinition = method;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method, typeof(CompilerGeneratedAttribute)));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(
                () => method.IsDefined(assembly, typeof(CompilerGeneratedAttribute)) ? null : new ILMethodBodyWithMonoCecilCil(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return body.Value; }
        }

        public MethodDefinition MethodDefinition { get; private set; }
    }
}
