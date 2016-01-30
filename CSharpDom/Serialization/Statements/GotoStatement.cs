using System;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class GotoStatement : IGotoStatement
    {
        public string LabelName { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
