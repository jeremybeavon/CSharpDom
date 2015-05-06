using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed partial class LinqBuilder : CSharpSyntaxVisitor<ILinqExpressionMapping>
    {
        private readonly SemanticModel semanticModel;
        private readonly TypeResolver typeResolver;
        private readonly IDictionary<string, ParameterExpression> parameters;
        private readonly LocalVariables localVariables;
        private readonly LabelTargets labelTargets;

        public LinqBuilder(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
            typeResolver = new TypeResolver(semanticModel);
            parameters = new Dictionary<string, ParameterExpression>();
            localVariables = new LocalVariables();
            labelTargets = new LabelTargets();
        }

        public override ILinqExpressionMapping DefaultVisit(SyntaxNode node)
        {
            ////SymbolInfo test = semanticModel.GetSymbolInfo(node);
            throw new NotSupportedException();
        }
    }
}
