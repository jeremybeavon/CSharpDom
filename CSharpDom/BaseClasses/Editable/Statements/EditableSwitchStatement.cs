using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> :
        EditableStatement,
        IEditableSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>
        where TExpression : IEditableExpression
        where TSwitchCaseStatement : IEditableSwitchCaseStatement
        where TDefaultCaseStatement : IEditableDefaultCaseStatement
    {
        public abstract ICollection<TSwitchCaseStatement> Cases { get; set; }

        public abstract TDefaultCaseStatement DefaultCase { get; set; }

        public abstract TExpression Expression { get; set; }

        IReadOnlyCollection<TSwitchCaseStatement> ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>.Cases
        {
            get { return new ReadOnlyCollectionWrapper<TSwitchCaseStatement>(Cases); }
        }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitSwitchStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
