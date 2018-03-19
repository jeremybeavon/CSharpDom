using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface ILambdaExpression<TExpression> : ILambdaExpression, IHasAsync
        where TExpression : IExpression
    {
        string ParameterName { get; }

        TExpression Expression { get; }
    }
}
