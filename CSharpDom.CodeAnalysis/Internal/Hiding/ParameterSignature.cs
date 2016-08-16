using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal.Hiding
{
    internal sealed class ParameterSignature : AbstractMethodParameter<AttributeGroupNotSupported, ITypeReferenceWithCodeAnalysis>,
        IIndexerParameter<AttributeGroupNotSupported, ITypeReferenceWithCodeAnalysis>
    {
        private readonly ParameterModifier modifier;
        private readonly string name;
        private readonly ITypeReferenceWithCodeAnalysis parameterType;

        public ParameterSignature(AssemblyWithCodeAnalysis assembly, ParameterDefinition parameter)
        {
            modifier = parameter.Modifier(assembly);
            name = string.Format("parameter{0}", parameter.Index + 1);
            parameterType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, parameter.ParameterType);
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

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameterType; }
        }

        IndexerParameterModifier IHasModifier<IndexerParameterModifier>.Modifier
        {
            get { return Modifier == ParameterModifier.Params ? IndexerParameterModifier.Params : IndexerParameterModifier.None; }
        }
    }
}
