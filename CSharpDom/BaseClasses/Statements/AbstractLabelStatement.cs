using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractLabelStatement : AbstractStatement, ILabelStatement
    {
        public abstract string LabelName { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitLabelStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
