using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface ILinqExpressionMapping
    {
        IReadOnlyCollection<Expression> Expressions { get; }

        SyntaxNode Syntax { get; }

        IReadOnlyCollection<ParameterExpression> LocalVariablesDeclarations { get; }
    }
}
