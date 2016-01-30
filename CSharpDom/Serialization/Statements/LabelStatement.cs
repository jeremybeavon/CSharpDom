using System;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class LabelStatement : ILabelStatement
    {
        public string LabelName { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLabelStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
