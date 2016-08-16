using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis
{
    public sealed class IndexerParameterWithCodeAnalysis :
        AbstractIndexerParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>
    {
        private readonly ParameterWithCodeAnalysis parameter;

        internal IndexerParameterWithCodeAnalysis(ParameterWithCodeAnalysis parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
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

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameter.ParameterType; }
        }
    }
}
