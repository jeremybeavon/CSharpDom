using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableBreakStatement : IBreakStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBreakStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
