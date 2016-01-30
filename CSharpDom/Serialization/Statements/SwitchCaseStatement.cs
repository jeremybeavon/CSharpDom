using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class SwitchCaseStatement : ISwitchCaseStatement<Expression, Statement>
    {
        public SwitchCaseStatement()
        {
            Statements = new List<Statement>();
        }

        public Expression Match { get; set; }

        public List<Statement> Statements { get; set; }

        IReadOnlyList<Statement> ISwitchCaseStatement<Expression, Statement>.Statements
        {
            get { return Statements; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchCaseStatementChildren(this, visitor);
        }
    }
}
