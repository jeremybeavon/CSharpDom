﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ForStatement : LinqExpressionMapping<BlockExpression, ForStatementSyntax>
    {
        public ForStatement(BlockExpression expression, ForStatementSyntax syntax)
            : base(expression, syntax)
        {
        }

        public IEnumerable<ILinqExpressionMapping> Initializers { get; internal set; }

        public ILinqExpressionMapping Condition { get; internal set; }

        public IEnumerable<ILinqExpressionMapping> Incrementors { get; internal set; }

        public ILinqExpressionMapping Statement { get; internal set; }
    }
}
