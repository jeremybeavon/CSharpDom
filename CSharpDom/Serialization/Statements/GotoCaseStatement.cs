using System;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class GotoCaseStatement : IGotoCaseStatement
    {
        public string CaseName { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
