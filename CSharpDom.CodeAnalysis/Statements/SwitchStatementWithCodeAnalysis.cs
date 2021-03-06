﻿using System.Collections.Generic;
using CSharpDom.Editable.Statements;
using CSharpDom.Editable.Expressions;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class SwitchStatementWithCodeAnalysis<TExpression, TSwitchCaseStatement, TDefaultCaseStatement> :
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

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitSwitchStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitSwitchStatementChildren(this, visitor);
        }
    }
}
