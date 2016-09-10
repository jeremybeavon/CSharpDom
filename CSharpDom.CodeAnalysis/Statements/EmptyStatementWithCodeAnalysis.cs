using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class EmptyStatementWithCodeAnalysis : IEmptyStatement
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
