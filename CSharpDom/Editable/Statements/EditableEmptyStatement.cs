using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableEmptyStatement : IEmptyStatement
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
