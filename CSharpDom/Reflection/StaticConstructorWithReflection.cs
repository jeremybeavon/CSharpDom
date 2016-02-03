using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticConstructorWithReflection :
        AbstractStaticConstructor<AttributeWithReflection, ITypeWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasConstructorInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        public StaticConstructorWithReflection(ITypeWithReflection declaringType, ConstructorInfo constructor)
        {
            this.declaringType = declaringType;
            ConstructorInfo = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(constructor));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(constructor));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        public ConstructorInfo ConstructorInfo { get; private set; }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }
    }
}
