using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableSwitchCaseStatement<TExpression, TStatement> :
        EditableStatement,
        IEditableSwitchCaseStatement<TExpression, TStatement>
        where TExpression : IEditableExpression
        where TStatement : IEditableStatement
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

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchCaseStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitSwitchCaseStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchCaseStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
