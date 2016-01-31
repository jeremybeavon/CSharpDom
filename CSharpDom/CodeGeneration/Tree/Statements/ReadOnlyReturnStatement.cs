using System;
using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyReturnStatement :
        AbstractReturnStatement<IExpression>,
        IRawExpression
    {
        private readonly IExpression expression;
        private readonly string rawExpression;

        public ReadOnlyReturnStatement(ReturnStatement returnStatement)
        {
            if (returnStatement.Expression == null)
            {
                expression = this;
                rawExpression = returnStatement.RawExpression ?? string.Empty;
            }
            else
            {
                expression = LinqExpressionBuilder.BuildExpression(returnStatement.Expression);
            }
        }

        public override IExpression Expression
        {
            get { return expression; }
        }

        string IRawExpression.Expression
        {
            get { return rawExpression; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            if (rawExpression == null)
            {
                expression.Accept(visitor);
            }
            else
            {
                visitor.VisitRawExpression(this);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            if (rawExpression != null)
            {
                expression.AcceptChildren(visitor);
            }
        }
    }
}
