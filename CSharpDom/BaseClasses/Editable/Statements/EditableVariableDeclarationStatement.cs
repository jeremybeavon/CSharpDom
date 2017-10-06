using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableVariableDeclarationStatement<TTypeReference, TExpression> :
        AbstractStatement,
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

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitVariableDeclarationStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
