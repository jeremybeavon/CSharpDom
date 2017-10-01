using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractContinueStatement : AbstractStatement, IContinueStatement
    {
        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitContinueStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
