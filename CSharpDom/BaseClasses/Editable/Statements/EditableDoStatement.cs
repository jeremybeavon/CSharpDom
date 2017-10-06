using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableDoStatement<TExpression, TStatement> :
        AbstractStatement,
        IDoStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract TStatement Statement { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitDoStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitDoStatementChildren(this, visitor);
        }
    }
}
