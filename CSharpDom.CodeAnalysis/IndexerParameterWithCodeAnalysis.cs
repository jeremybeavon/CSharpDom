using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class IndexerParameterWithCodeAnalysis :
        EditableIndexerParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<ParameterSyntax>
    {
        private readonly ParameterWithCodeAnalysis parameter;

        internal IndexerParameterWithCodeAnalysis()
        {
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return parameter.Attributes; }
            set { parameter.Attributes = value; }
        }

        public override IndexerParameterModifier Modifier
        {
            get { return Syntax.Modifiers.Any(SyntaxKind.ParamsKeyword) ? IndexerParameterModifier.Params : IndexerParameterModifier.None; }
            set
            {
                ParameterSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(
                    syntax.Modifiers.Remove(new HashSet<SyntaxKind>(new[] { SyntaxKind.ParamsKeyword })).Add(SyntaxKind.ParamsKeyword));
            }
        }

        public override string Name
        {
            get { return parameter.Name; }
            set { parameter.Name = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameter.ParameterType; }
            set { parameter.ParameterType = value; }
        }

        public ParameterSyntax Syntax
        {
            get { return parameter.Syntax; }
            set { parameter.Syntax = value; }
        }
    }
}
