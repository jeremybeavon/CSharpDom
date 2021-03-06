﻿using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IAnonymousMethodExpression<TParameter, TStatement> : IAnonymousMethodExpression, IHasAsync
        where TParameter : IAnonymousMethodParameter
        where TStatement : IStatement
    {
        IReadOnlyList<TParameter> Parameters { get; }

        IReadOnlyList<TStatement> Statements { get; }
    }
}
