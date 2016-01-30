using System;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class IfStatement : IIfStatement<Expression, Statement>
    {
        public Expression Condition { get; set; }

        public Statement ElseStatement { get; set; }

        public Statement ThenStatement { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitIfStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitIfStatementChildren(this, visitor);
        }
    }
}
