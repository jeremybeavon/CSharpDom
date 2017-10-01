using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;
using CSharpDom.Common.Statements;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableSwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> :
        AbstractStatement,
        ISwitchStatement<TExpression, TSwitchCaseStatement, TDefaultCaseStatement>
        where TExpression : IExpression
        where TSwitchCaseStatement : ISwitchCaseStatement
        where TDefaultCaseStatement : IDefaultCaseStatement
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

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchStatementChildren(this, visitor);
        }
    }
}
