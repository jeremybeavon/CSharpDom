using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class DefaultCaseStatement : IDefaultCaseStatement<Statement>
    {
        public DefaultCaseStatement()
        {
            Statements = new List<Statement>();
        }

        public List<Statement> Statements { get; set; }

        IReadOnlyList<Statement> IDefaultCaseStatement<Statement>.Statements
        {
            get { return Statements; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitDefaultCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitDefaultCaseStatementChildren(this, visitor);
        }
    }
}
