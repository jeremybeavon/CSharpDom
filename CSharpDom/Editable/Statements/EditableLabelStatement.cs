using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableLabelStatement : ILabelStatement
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
