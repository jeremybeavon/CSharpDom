using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableForeachStatement<TTypeReference, TExpression, TStatement> :
        AbstractStatement,
        IForeachStatement<TTypeReference, TExpression, TStatement>
        where TTypeReference : ITypeReference
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Iterator { get; set; }

        public abstract TStatement Statement { get; set; }

        public abstract TTypeReference Type { get; set; }

        public abstract string VariableName { get; set; }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForeachStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForeachStatementChildren(this, visitor);
        }
    }
}
