using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractBlockStatement<TStatement> : AbstractStatement, IBlockStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IReadOnlyList<TStatement> Statements { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBlockStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitBlockStatementChildren(this, visitor);
        }
    }
}
