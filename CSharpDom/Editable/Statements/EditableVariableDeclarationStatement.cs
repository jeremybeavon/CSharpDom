using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common;
using System;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableVariableDeclarationStatement<TTypeReference, TExpression> :
        IVariableDeclarationStatement<TTypeReference, TExpression>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IList<TExpression> Expressions { get; set; }

        public abstract TTypeReference Type { get; set; }

        IReadOnlyList<TExpression> IVariableDeclarationStatement<TTypeReference, TExpression>.Expressions
        {
            get { return new ReadOnlyCollection<TExpression>(Expressions); }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitVariableDeclarationStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
