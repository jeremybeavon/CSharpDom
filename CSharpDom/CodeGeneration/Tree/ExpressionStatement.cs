﻿using System;
using System.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ExpressionStatement : Statement, IExpressionStatement
    {
        public Expression<Func<object>> Expression { get; set; }

        public string RawExpression { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
