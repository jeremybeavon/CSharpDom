﻿namespace CSharpDom.Common.Expressions
{
    public interface IQueryLetExpression<TExpression> : IQueryLetExpression
        where TExpression : IExpression
    {
        string Identifier { get; }

        TExpression Expression { get; }
    }
}
