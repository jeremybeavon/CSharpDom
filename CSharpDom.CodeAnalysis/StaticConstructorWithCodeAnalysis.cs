using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticConstructorWithCodeAnalysis :
        AbstractStaticConstructor<AttributeGroupWithCodeAnalysis, ITypeWithCodeAnalysis, MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        public StaticConstructorWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition constructor)
        {
            this.declaringType = declaringType;
            MethodDefinition = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, constructor));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(constructor));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        public MethodDefinition MethodDefinition { get; private set; }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }
    }
}
