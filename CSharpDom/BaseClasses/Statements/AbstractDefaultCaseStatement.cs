using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractDefaultCaseStatement<TStatement> :
        AbstractStatement,
        IDefaultCaseStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IReadOnlyList<TStatement> Statements { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitDefaultCaseStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitDefaultCaseStatementChildren(this, visitor);
        }
    }
}
