using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class LabelStatementWithCodeAnalysis : ILabelStatement
    {
        public abstract string LabelName { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLabelStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
