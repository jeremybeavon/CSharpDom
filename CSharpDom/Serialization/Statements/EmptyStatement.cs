using System;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class EmptyStatement : IEmptyStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitEmptyStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
