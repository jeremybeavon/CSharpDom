using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticConstructorWithMonoCecil :
        AbstractStaticConstructor<AttributeWithMonoCecil, ITypeWithMonoCecil, ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        public StaticConstructorWithMonoCecil(ITypeWithMonoCecil declaringType, MethodDefinition constructor)
        {
            this.declaringType = declaringType;
            MethodDefinition = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, constructor));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(constructor));
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

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }
    }
}
