using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableVariableDeclarationStatement<TTypeReference, TExpression> :
        EditableStatement,
        IEditableVariableDeclarationStatement<TTypeReference, TExpression>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        public abstract IList<TExpression> Expressions { get; set; }

        public abstract TTypeReference Type { get; set; }

        IReadOnlyList<TExpression> IVariableDeclarationStatement<TTypeReference, TExpression>.Expressions
        {
            get { return new ReadOnlyCollection<TExpression>(Expressions); }
        }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitVariableDeclarationStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitVariableDeclarationStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
        }
    }
}
