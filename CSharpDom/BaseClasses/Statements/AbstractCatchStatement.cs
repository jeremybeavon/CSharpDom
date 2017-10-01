using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractCatchStatement<TTypeReference, TStatement> :
        AbstractStatement,
        ICatchStatement<TTypeReference, TStatement>
        where TTypeReference : ITypeReference
        where TStatement : IStatement
    {
        public abstract IReadOnlyList<TStatement> Statements { get; }

        public abstract TTypeReference Type { get; }

        public abstract string VariableName { get; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitCatchStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitCatchStatementChildren(this, visitor);
        }
    }
}
