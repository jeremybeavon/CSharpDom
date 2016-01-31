﻿using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractListInitializerExpression<TCreateListExpression, TExpression> :
        IListInitializerExpression<TCreateListExpression, TExpression>
        where TCreateListExpression : ICreateListExpression
        where TExpression : IExpression
    {
        public abstract TCreateListExpression CreateListExpression { get; }

        public abstract IReadOnlyList<IReadOnlyList<TExpression>> InitialValues { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitListInitializerExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitListInitializerExpressionChildren(this, visitor);
        }
    }
}
