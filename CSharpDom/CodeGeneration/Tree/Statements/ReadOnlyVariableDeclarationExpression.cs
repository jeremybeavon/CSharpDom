using System;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyVariableDeclarationExpression : IIdentifierExpression
    {
        private readonly IExpression expression;

        public ReadOnlyVariableDeclarationExpression(string name)
        {
            Name = name;
        }

        public ReadOnlyVariableDeclarationExpression(IExpression expression)
        {
            this.expression = expression;
        }

        public string Name { get; private set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                expression.Accept(visitor);
            }
            else
            {
                visitor.VisitIdentifierExpression(this);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                expression.AcceptChildren(visitor);
            }
        }
    }
}
