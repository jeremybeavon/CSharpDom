using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableGotoCaseStatement : IGotoCaseStatement
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
