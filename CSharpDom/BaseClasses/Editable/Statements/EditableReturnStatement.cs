using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableReturnStatement<TExpression> :
        AbstractStatement,
        IReturnStatement<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitReturnStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
