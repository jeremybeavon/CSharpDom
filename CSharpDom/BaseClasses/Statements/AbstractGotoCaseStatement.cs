using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractGotoCaseStatement : AbstractStatement, IGotoCaseStatement
    {
        public abstract string CaseName { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
