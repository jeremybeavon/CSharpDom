using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableForStatement<TExpression, TForInitializerStatement, TStatement> :
        AbstractStatement,
        IForStatement<TExpression, TForInitializerStatement, TStatement>
        where TExpression : IExpression
        where TForInitializerStatement : IForInitializerStatement
        where TStatement : IStatement
    {
        public abstract TExpression Condition { get; set; }

        public abstract ICollection<TExpression> IncrementExpressions { get; set; }

        public abstract TForInitializerStatement InitialValueStatement { get; set; }

        public abstract TStatement Statement { get; set; }

        IReadOnlyCollection<TExpression> IForStatement<TExpression, TForInitializerStatement, TStatement>.IncrementExpressions
        {
            get { return new ReadOnlyCollectionWrapper<TExpression>(IncrementExpressions); }
        }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForStatementChildren(this, visitor);
        }
    }
}
