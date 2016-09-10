using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ContinueStatementWithCodeAnalysis : IContinueStatement
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
