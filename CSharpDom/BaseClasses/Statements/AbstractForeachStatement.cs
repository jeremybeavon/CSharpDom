using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractForeachStatement<TTypeReference, TExpression, TStatement> :
        IForeachStatement<TTypeReference, TExpression, TStatement>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Iterator { get; }

        public abstract TStatement Statement { get; }

        public abstract TTypeReference Type { get; }

        public abstract string VariableName { get; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForeachStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForeachStatementChildren(this, visitor);
        }
    }
}
