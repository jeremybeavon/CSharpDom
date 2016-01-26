using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractBlockStatement<TStatement> : IBlockStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IReadOnlyList<TStatement> Statements { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBlockStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitBlockStatementChildren(this, visitor);
        }
    }
}
