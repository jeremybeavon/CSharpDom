using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class IndexerParameterWithReflection :
        AbstractIndexerParameter<AttributeWithReflection, ITypeReferenceWithReflection>
    {
        private readonly ParameterWithReflection parameter;

        internal IndexerParameterWithReflection(ParameterWithReflection parameter)
        {
            this.parameter = parameter;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
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

        public override ITypeReferenceWithReflection ParameterType
        {
            get { return parameter.ParameterType; }
        }
    }
}
