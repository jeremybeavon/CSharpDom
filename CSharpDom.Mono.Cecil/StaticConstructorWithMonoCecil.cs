using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticConstructorWithMonoCecil :
        AbstractStaticConstructor<AttributeWithMonoCecil, ITypeWithMonoCecil, ILMethodBodyWithMonoCecilEmit>,
        IHasConstructorInfo
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        public StaticConstructorWithMonoCecil(ITypeWithMonoCecil declaringType, ConstructorInfo constructor)
        {
            this.declaringType = declaringType;
            ConstructorInfo = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(constructor));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(constructor));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return body.Value; }
        }

        public ConstructorInfo ConstructorInfo { get; private set; }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }
    }
}
