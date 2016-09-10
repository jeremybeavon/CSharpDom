using System;
using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class ForStatementWithCodeAnalysis<TExpression, TForInitializerStatement, TStatement> :
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

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitForStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitForStatementChildren(this, visitor);
        }
    }
}
