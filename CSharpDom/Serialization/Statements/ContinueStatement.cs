using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class ContinueStatement : IContinueStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitContinueStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
