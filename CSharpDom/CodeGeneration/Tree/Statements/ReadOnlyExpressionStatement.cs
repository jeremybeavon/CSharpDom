using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using CSharpDom.Linq.Expressions;
using CSharpDom.Text;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyExpressionStatement :
        AbstractExpressionStatement<IExpression>,
        IForInitializerStatement,
        IRawExpression
    {
        private readonly IExpression expression;
        private readonly string rawExpression;

        public ReadOnlyExpressionStatement(ExpressionStatement statement)
        {
            if (statement.Expression == null)
            {
                expression = this;
                rawExpression = statement.RawExpression.Statement ?? string.Empty;
            }
            else
            {
                expression = LinqExpressionBuilder.BuildExpression(statement.Expression.Body);
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

        public string ToSourceCode()
        {
            return ((IVisitable<IGenericExpressionVisitor>)this).ToSourceCode();
        }
    }
}
