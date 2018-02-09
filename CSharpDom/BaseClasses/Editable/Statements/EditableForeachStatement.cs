using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableForeachStatement<TTypeReference, TExpression, TStatement> :
        EditableStatement,
        IEditableForeachStatement<TTypeReference, TExpression, TStatement>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
    {
        public abstract TExpression Iterator { get; set; }

        public abstract TStatement Statement { get; set; }

        public abstract TTypeReference Type { get; set; }

        public abstract string VariableName { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForeachStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitForeachStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForeachStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
