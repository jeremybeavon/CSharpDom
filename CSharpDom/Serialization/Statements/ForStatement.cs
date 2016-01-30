using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ForStatement : IForStatement<Expression, ForInitializerStatement, Statement>
    {
        public ForStatement()
        {
            IncrementExpressions = new List<Expression>();
        }

        public Expression Condition { get; set; }

        public List<Expression> IncrementExpressions { get; set; }

        public ForInitializerStatement InitialValueStatement { get; set; }

        public Statement Statement { get; set; }

        IReadOnlyCollection<Expression> IForStatement<Expression, ForInitializerStatement, Statement>.IncrementExpressions
        {
            get { return IncrementExpressions; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForStatementChildren(this, visitor);
        }
    }
}
