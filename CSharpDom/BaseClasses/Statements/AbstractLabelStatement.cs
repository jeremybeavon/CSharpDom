using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractLabelStatement : ILabelStatement
    {
        public abstract string LabelName { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLabelStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
