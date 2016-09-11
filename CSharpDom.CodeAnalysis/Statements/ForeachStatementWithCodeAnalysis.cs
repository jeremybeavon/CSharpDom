using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common;
using CSharpDom.Editable.Expressions;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ForeachStatementWithCodeAnalysis<TTypeReference, TExpression, TStatement> :
        IForeachStatement<TTypeReference, TExpression, TStatement>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Iterator { get; set; }

        public abstract TStatement Statement { get; set; }

        public abstract TTypeReference Type { get; set; }

        public abstract string VariableName { get; set; }

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
