﻿using System;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExpressionStatement : Statement
    {
        public Expression<Func<object>> Expression { get; set; }

        public RawStatement RawExpression { get; set; }
    }
}
