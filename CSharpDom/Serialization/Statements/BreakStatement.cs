using System;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class BreakStatement : IBreakStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBreakStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
