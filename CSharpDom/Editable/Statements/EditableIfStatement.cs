using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableIfStatement<TExpression, TStatement> :
        IIfStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract TStatement ElseStatement { get; set; }

        public abstract TStatement ThenStatement { get; set; }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitIfStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitIfStatementChildren(this, visitor);
        }
    }
}
