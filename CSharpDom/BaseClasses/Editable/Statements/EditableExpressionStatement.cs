using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableExpressionStatement<TExpression> :
        AbstractStatement,
        IExpressionStatement<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitExpressionStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}
