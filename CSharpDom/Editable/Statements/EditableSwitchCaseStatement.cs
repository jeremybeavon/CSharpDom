using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Wrappers.Internal;
using System;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableSwitchCaseStatement<TExpression, TStatement> :
        ISwitchCaseStatement<TExpression, TStatement>
        where TExpression : IExpression
        where TStatement : IStatement
    {
        public abstract ICollection<TExpression> Matches { get; set; }

        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyCollection<TExpression> ISwitchCaseStatement<TExpression, TStatement>.Matches
        {
            get { return new ReadOnlyCollectionWrapper<TExpression>(Matches); }
        }

        IReadOnlyList<TStatement> ISwitchCaseStatement<TExpression, TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchCaseStatementChildren(this, visitor);
        }
    }
}
