using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyExpressionStatement : AbstractExpressionStatement<IExpression>, IExpression
    {
        private readonly IExpression expression;

        public ReadOnlyExpressionStatement(ExpressionStatement statement)
        {
            expression = this;
        }

        public override IExpression Expression
        {
            get { return expression; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            expression.Accept(visitor);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            expression.AcceptChildren(visitor);
        }
    }
}
