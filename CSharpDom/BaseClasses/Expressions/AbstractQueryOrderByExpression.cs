﻿using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryOrderByExpression<TOrderingExpression> :
        AbstractExpression,
        IQueryOrderByExpression<TOrderingExpression>
        where TOrderingExpression : IQueryOrderingExpression
    {
        public abstract IReadOnlyList<TOrderingExpression> Orders { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderByExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderByExpressionChildren(this, visitor);
        }
    }
}
