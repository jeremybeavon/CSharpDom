using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractBreakStatement : AbstractStatement, IBreakStatement
    {
        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBreakStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
