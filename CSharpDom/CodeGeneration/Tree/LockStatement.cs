﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class LockStatement : Statement
    {
        public IExpressionStatement Expression { get; set; }

        public Statement Statement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Expression.AcceptIfNotNull(visitor);
            Statement.AcceptIfNotNull(visitor);
        }
    }
}
