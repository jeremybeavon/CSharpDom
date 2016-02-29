using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal.Hiding
{
    internal sealed class ParameterSignature : AbstractMethodParameter<AttributeGroupNotSupported, ITypeReferenceWithMonoCecil>,
        IIndexerParameter<AttributeGroupNotSupported, ITypeReferenceWithMonoCecil>
    {
        private readonly ParameterModifier modifier;
        private readonly string name;
        private readonly ITypeReferenceWithMonoCecil parameterType;

        public ParameterSignature(AssemblyWithMonoCecil assembly, ParameterDefinition parameter)
        {
            modifier = parameter.Modifier(assembly);
            name = string.Format("parameter{0}", parameter.Index + 1);
            parameterType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, parameter.ParameterType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ParameterModifier Modifier
        {
            get { return modifier; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override ITypeReferenceWithMonoCecil ParameterType
        {
            get { return parameterType; }
        }

        IndexerParameterModifier IHasModifier<IndexerParameterModifier>.Modifier
        {
            get { return Modifier == ParameterModifier.Params ? IndexerParameterModifier.Params : IndexerParameterModifier.None; }
        }
    }
}
