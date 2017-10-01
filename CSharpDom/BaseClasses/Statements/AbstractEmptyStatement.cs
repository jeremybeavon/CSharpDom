using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractEmptyStatement : AbstractStatement, IEmptyStatement
    {
        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitEmptyStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
