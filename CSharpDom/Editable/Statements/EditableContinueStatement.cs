using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableContinueStatement : IContinueStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitContinueStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
