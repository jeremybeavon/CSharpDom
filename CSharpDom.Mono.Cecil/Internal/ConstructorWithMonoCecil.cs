using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class ConstructorWithMonoCecil :
        AbstractConstructor<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ConstructorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilCil>,
        IHasMethodDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly MethodDefinition constructor;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Parameters<ConstructorParameterWithMonoCecil>> parameters;
        private readonly Lazy<ILMethodBodyWithMonoCecilCil> body;

        internal ConstructorWithMonoCecil(ITypeWithMonoCecil declaringType, MethodDefinition constructor)
        {
            this.declaringType = declaringType;
            this.constructor = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, constructor));
            parameters = new Lazy<Parameters<ConstructorParameterWithMonoCecil>>(
                () => new Parameters<ConstructorParameterWithMonoCecil>(declaringType.Assembly, constructor, parameter => new ConstructorParameterWithMonoCecil(parameter)));
            body = new Lazy<ILMethodBodyWithMonoCecilCil>(() => new ILMethodBodyWithMonoCecilCil(constructor));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<ConstructorParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return constructor; }
        }

        public override ILMethodBodyWithMonoCecilCil Body
        {
            get { return body.Value; }
        }
    }
}
