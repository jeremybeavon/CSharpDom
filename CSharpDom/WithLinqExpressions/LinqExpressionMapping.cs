using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public abstract class LinqExpressionMapping<TExpression, TSyntax> : ILinqExpressionMapping
        where TExpression : Expression
        where TSyntax : SyntaxNode
    {
        protected LinqExpressionMapping(TExpression expression, TSyntax syntax)
            : this(new[] { expression }, syntax)
        {
        }

        protected LinqExpressionMapping(IReadOnlyCollection<TExpression> expressions, TSyntax syntax)
        {
            Expressions = expressions;
            Syntax = syntax;
        }

        public IReadOnlyCollection<TExpression> Expressions { get; private set; }

        public TSyntax Syntax { get; private set; }

        IReadOnlyCollection<Expression> ILinqExpressionMapping.Expressions
        {
            get { return Expressions; }
        }

        SyntaxNode ILinqExpressionMapping.Syntax
        {
            get { return Syntax; }
        }

        public IReadOnlyCollection<ParameterExpression> LocalVariablesDeclarations
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
