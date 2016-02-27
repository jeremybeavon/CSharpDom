using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil
{
    public sealed class DelegateParameterWithMonoCecil :
        AbstractDelegateParameter<AttributeWithMonoCecil, ITypeReferenceWithMonoCecil>
    {
        private readonly ParameterWithMonoCecil parameter;

        internal DelegateParameterWithMonoCecil(ParameterWithMonoCecil parameter)
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
