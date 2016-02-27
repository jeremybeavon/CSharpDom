using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class ConstructorWithMonoCecil :
        AbstractConstructor<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ConstructorParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>,
        IHasConstructorInfo
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly ConstructorInfo constructor;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Parameters<ConstructorParameterWithMonoCecil>> parameters;
        private readonly Lazy<ILMethodBodyWithMonoCecilEmit> body;

        internal ConstructorWithMonoCecil(ITypeWithMonoCecil declaringType, ConstructorInfo constructor)
        {
            this.declaringType = declaringType;
            this.constructor = constructor;
            attributes = new Lazy<Attributes>(() => new Attributes(constructor));
            parameters = new Lazy<Parameters<ConstructorParameterWithMonoCecil>>(
                () => new Parameters<ConstructorParameterWithMonoCecil>(constructor, parameter => new ConstructorParameterWithMonoCecil(parameter)));
            body = new Lazy<ILMethodBodyWithMonoCecilEmit>(() => new ILMethodBodyWithMonoCecilEmit(constructor));
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

        public ConstructorInfo ConstructorInfo
        {
            get { return constructor; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return body.Value; }
        }
    }
}
