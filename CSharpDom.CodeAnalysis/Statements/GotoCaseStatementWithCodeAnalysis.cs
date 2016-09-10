using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class GotoCaseStatementWithCodeAnalysis : IGotoCaseStatement
    {
        public abstract string CaseName { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
