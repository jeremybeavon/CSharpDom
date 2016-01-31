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
            Matches = new List<Expression>();
            Statements = new List<Statement>();
        }

        public List<Expression> Matches { get; set; }

        public List<Statement> Statements { get; set; }

        IReadOnlyCollection<Expression> ISwitchCaseStatement<Expression, Statement>.Matches
        {
            get { return Matches; }
        }

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
