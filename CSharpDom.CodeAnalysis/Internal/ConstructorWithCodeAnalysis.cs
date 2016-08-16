using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class ConstructorWithCodeAnalysis :
        AbstractConstructor<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ConstructorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly MethodDefinition constructor;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Parameters<ConstructorParameterWithCodeAnalysis>> parameters;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal ConstructorWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition constructor)
        {
            this.declaringType = declaringType;
            this.constructor = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, constructor));
            parameters = new Lazy<Parameters<ConstructorParameterWithCodeAnalysis>>(
                () => new Parameters<ConstructorParameterWithCodeAnalysis>(declaringType.Assembly, constructor, parameter => new ConstructorParameterWithCodeAnalysis(parameter)));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(constructor));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<ConstructorParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return constructor; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }
    }
}
