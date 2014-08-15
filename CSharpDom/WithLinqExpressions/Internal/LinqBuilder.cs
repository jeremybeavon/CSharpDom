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
        private readonly IDictionary<string, ParameterExpression> parameters;
        private readonly IDictionary<string, ParameterExpression> localVariables;

        public LinqBuilder(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
            parameters = new Dictionary<string, ParameterExpression>();
            localVariables = new Dictionary<string, ParameterExpression>();
        }

        public override ILinqExpressionMapping DefaultVisit(SyntaxNode node)
        {
            SymbolInfo test = semanticModel.GetSymbolInfo(node);
            throw new NotSupportedException();
        }
    }
}
