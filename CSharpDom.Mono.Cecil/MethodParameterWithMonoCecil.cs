using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil
{
    public sealed class MethodParameterWithMonoCecil :
        AbstractMethodParameter<AttributeWithMonoCecil, ITypeReferenceWithMonoCecil>
    {
        private readonly ParameterWithMonoCecil parameter;

        internal MethodParameterWithMonoCecil(ParameterWithMonoCecil parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return parameter.Attributes; }
        }

        public override ParameterModifier Modifier
        {
            get { return parameter.Modifier; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithMonoCecil ParameterType
        {
            get { return parameter.ParameterType; }
        }
    }
}
