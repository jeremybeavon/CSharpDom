using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil
{
    public sealed class IndexerParameterWithMonoCecil :
        AbstractIndexerParameter<AttributeWithMonoCecil, ITypeReferenceWithMonoCecil>
    {
        private readonly ParameterWithMonoCecil parameter;

        internal IndexerParameterWithMonoCecil(ParameterWithMonoCecil parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return parameter.Attributes; }
        }

        public override IndexerParameterModifier Modifier
        {
            get { return parameter.Modifier == ParameterModifier.Params ? IndexerParameterModifier.Params : IndexerParameterModifier.None; }
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
