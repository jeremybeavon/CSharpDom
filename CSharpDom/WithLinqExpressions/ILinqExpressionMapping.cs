using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public interface ILinqExpressionMapping
    {
        Expression Expression { get; }

        SyntaxNode Syntax { get; }

        IReadOnlyCollection<ParameterExpression> LocalVariablesDeclarations { get; }
    }
}
