using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyIndexerParameter : AbstractIndexerParameter<AttributeGroupNotSupported, ReadOnlyTypeReference>
    {
        private readonly MethodParameter parameter;
        private readonly ReadOnlyTypeReference parameterType;

        public ReadOnlyIndexerParameter(MethodParameter parameter)
        {
            this.parameter = parameter;
            parameterType = new ReadOnlyTypeReference(parameter.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IndexerParameterModifier Modifier
        {
            get { return parameter.Modifier == ParameterModifier.Params ? IndexerParameterModifier.Params : IndexerParameterModifier.None; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ReadOnlyTypeReference ParameterType
        {
            get { return parameterType; }
        }

        public static IReadOnlyList<ReadOnlyIndexerParameter> Create(IEnumerable<MethodParameter> parameters)
        {
            return parameters.ToArray(parameter => new ReadOnlyIndexerParameter(parameter));
        }
    }
}
