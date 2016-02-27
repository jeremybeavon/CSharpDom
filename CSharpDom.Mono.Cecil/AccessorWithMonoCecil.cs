using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AccessorWithMonoCecil :
        AbstractAccessor<AttributeWithMonoCecil, ILMethodBodyWithMonoCecilEmit>,
        IHasMethodInfo
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        internal AccessorWithMonoCecil(MethodInfo method)
        {
            MethodInfo = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method, typeof(CompilerGeneratedAttribute)));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(
                () => method.IsDefined(typeof(CompilerGeneratedAttribute)) ? null : new ILMethodBodyWithMonoCecilEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return body.Value; }
        }

        public MethodInfo MethodInfo { get; private set; }
    }
}
