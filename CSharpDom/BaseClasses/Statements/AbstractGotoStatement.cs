using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractGotoStatement : AbstractStatement, IGotoStatement
    {
        public abstract string LabelName { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
