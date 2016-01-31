using CSharpDom.BaseClasses.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class TypeBinaryExpressionWithLinqExpressions :
        AbstractBinaryOperatorExpression<ILinqExpression>,
        ILinqExpression<TypeBinaryExpression>
    {
        private readonly ILinqExpression left;
        private readonly ILinqExpression right;

        public TypeBinaryExpressionWithLinqExpressions(TypeBinaryExpression expression)
        {
            Expression = expression;
            left = LinqExpressionBuilder.BuildExpression(expression.Expression);
            //right = LinqExpressionBuilder.BuildExpression()
            right = LinqExpressionBuilder.BuildExpression(expression.Expression);
            throw new NotImplementedException();
        }

        public TypeBinaryExpression Expression { get; private set; }

        public override ILinqExpression Left
        {
            get { return left; }
        }

        public override BinaryOperatorExpressionType OperatorType
        {
            get
            {
                switch (Expression.NodeType)
                {
                    case ExpressionType.TypeAs:
                        return BinaryOperatorExpressionType.TypeAs;
                    case ExpressionType.TypeIs:
                        return BinaryOperatorExpressionType.TypeIs;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public override ILinqExpression Right
        {
            get { return right; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
