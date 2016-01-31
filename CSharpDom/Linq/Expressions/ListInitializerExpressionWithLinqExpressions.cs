using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Linq;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ListInitializerExpressionWithLinqExpressions :
        AbstractListInitializerExpression<ICreateListLinqExpression, ILinqExpression>,
        ILinqExpression<ListInitExpression>
    {
        private readonly ICreateListLinqExpression createListExpression;
        private readonly IReadOnlyList<IReadOnlyList<ILinqExpression>> initialValues;

        public ListInitializerExpressionWithLinqExpressions(ListInitExpression expression)
        {
            Expression = expression;
            createListExpression = LinqExpressionBuilder.BuildExpression(expression.NewExpression) as ICreateListLinqExpression;
            initialValues = LinqExpressionBuilder.BuildExpressions(expression.Initializers).ToArray();
        }

        public override ICreateListLinqExpression CreateListExpression
        {
            get { return createListExpression; }
        }

        public ListInitExpression Expression { get; private set; }

        public override IReadOnlyList<IReadOnlyList<ILinqExpression>> InitialValues
        {
            get { return initialValues; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
