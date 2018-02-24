using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ArrayIndexExpressionWithLinqExpressions :
        AbstractArrayIndexExpression<ILinqExpression, ILinqExpression>,
        ILinqExpression<IndexExpression>
    {
        private readonly ILinqExpression array;
        private readonly IReadOnlyList<ILinqExpression> indexes;

        public ArrayIndexExpressionWithLinqExpressions(IndexExpression expression)
        {
            Expression = expression;
            array = LinqExpressionBuilder.BuildExpression(expression.Object);
            indexes = LinqExpressionBuilder.BuildExpressions(expression.Arguments);
        }

        public override ILinqExpression Array
        {
            get { return array; }
        }

        public IndexExpression Expression { get; private set; }

        public override IReadOnlyList<ILinqExpression> Indexes
        {
            get { return indexes; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
