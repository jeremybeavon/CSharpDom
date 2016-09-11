﻿using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class UnaryOperatorExpressionWithCodeAnalysis<TExpression> : IUnaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Operand { get; set; }

        public abstract UnaryOperatorExpressionType OperatorType { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitUnaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitUnaryOperatorExpressionChildren(this, visitor);
        }
    }
}
