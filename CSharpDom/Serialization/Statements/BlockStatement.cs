using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class BlockStatement : IBlockStatement<Statement>
    {
        public BlockStatement()
        {
            Statements = new List<Statement>();
        }

        public List<Statement> Statements { get; set; }

        IReadOnlyList<Statement> IBlockStatement<Statement>.Statements
        {
            get { return Statements; }
        }

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
