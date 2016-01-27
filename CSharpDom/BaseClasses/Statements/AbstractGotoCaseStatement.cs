using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractGotoCaseStatement : IGotoCaseStatement
    {
        public abstract string CaseName { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitGotoCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
