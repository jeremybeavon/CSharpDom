using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection
{
    public sealed class AccessorWithReflection :
        AbstractAccessor<AttributeWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
    {
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal AccessorWithReflection(MethodInfo method)
        {
            MethodInfo = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method, typeof(CompilerGeneratedAttribute)));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(
                () => method.IsDefined(typeof(CompilerGeneratedAttribute)) ? null : new ILMethodBodyWithReflectionEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        public MethodInfo MethodInfo { get; private set; }
    }
}
