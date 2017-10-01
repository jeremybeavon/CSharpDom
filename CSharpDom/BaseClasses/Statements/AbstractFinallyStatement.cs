using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractFinallyStatement<TStatement> : AbstractStatement, IFinallyStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IReadOnlyList<TStatement> Statements { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitFinallyStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitFinallyStatementChildren(this, visitor);
        }
    }
}
