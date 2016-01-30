using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Statements
{
    public sealed class SwitchStatement : ISwitchStatement<Expression, SwitchCaseStatement, DefaultCaseStatement>
    {
        public SwitchStatement()
        {
            Cases = new List<SwitchCaseStatement>();
        }

        public List<SwitchCaseStatement> Cases { get; set; }

        public DefaultCaseStatement DefaultCase { get; set; }

        public Expression Expression { get; set; }

        IReadOnlyCollection<SwitchCaseStatement> ISwitchStatement<Expression, SwitchCaseStatement, DefaultCaseStatement>.Cases
        {
            get { return Cases; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchStatementChildren(this, visitor);
        }
    }
}
